import websockets
import asyncio


async def ws_client():
    uri = "ws://127.0.0.1:8000/ws"
    async with websockets.connect(uri) as ws:
        print("Conectando ao servidor...")

        while True:
            msg = str(input("Send your message ('quit' for stop): "))
            if msg.lower() == 'quit':
                print("Bye bye")
                break

            await ws.send(msg)
            res = await ws.recv()
            print(f"Server: {res}")


asyncio.run(ws_client())
