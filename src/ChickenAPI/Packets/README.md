# ChickenAPI Packet list

## CharacterScreen Packets (only in character selection screen)

### Sent by Client
- [x] [Char_DEL](CharacterScreen/Client/CharacterDeletePacketBase.cs)
- [x] [Char_NEW](CharacterScreen/Client/CharNewPacketBase.cs)
- [x] [EntryPoint](CharacterScreen/Client/EntryPointPacketBase.cs)
- [x] [game_start](CharacterScreen/Client/GameStartPacketBase.cs)
- [x] [select](CharacterScreen/Client/SelectPacketBase.cs)

### Sent by Server
- [x] [clist](CharacterScreen/Server/ClistPacketBase.cs)
- [x] [clist_end](CharacterScreen/Server/CListEndPacketBase.cs)
- [x] [clist_start](CharacterScreen/Server/ClistStartPacketBase.cs)
- [x] [info](CharacterScreen/Server/InfoPacketBase.cs)
- [x] [OK](CharacterScreen/Server/OkPacketBase.cs)


## Game Packets (sent/received only in game)

### Sent by Client
- [x] [gop](Game/Client/CharacterOptionPacket.cs)
- [x] [walk](Game/Client/EntryPointPacketBase.cs)

### Sent by Server
- [x] [fd](Game/Server/FdPacket.cs)
- [x] [in](Game/Server/InPacketBase.cs)