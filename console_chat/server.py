from fastapi import FastAPI, WebSocket
import uvicorn

app = FastAPI()
clients = set()


@app.websocket("/ws")
async def ws_endpoint(ws: WebSocket):
    await ws.accept()
    clients.add(ws)
    try:
        while True:
            data = await ws.receive_text()
            for client in clients:
                if client != ws:
                    await client.send_text(data)
    except Exception:
        pass
    finally:
        clients.remove(ws)

if __name__ == "__main__":
    uvicorn.run(app, host="127.0.0.1", port=8000)
