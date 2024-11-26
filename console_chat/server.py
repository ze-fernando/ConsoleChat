from fastapi import WebSocket, FastAPI
import uvicorn

app = FastAPI()


@app.websocket("/ws")
async def ws_endpoint(ws: WebSocket):
    await ws.accept()
    while True:
        data = await ws.receive_text()
        print(data)
        await ws.send_text(data)


if __name__ == "__main__":
    uvicorn.run(app, host="127.0.0.1", port=8000)
