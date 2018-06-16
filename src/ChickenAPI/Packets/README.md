
Welcome to .NET Core!
---------------------
Learn more about .NET Core: https://aka.ms/dotnet-docs
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli-docs

Telemetry
---------
The .NET Core tools collect usage data in order to help us improve your experience. The data is anonymous and doesn't include command-line arguments. The data is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET Core CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry

ASP.NET Core
------------
Successfully installed the ASP.NET Core HTTPS Development Certificate.
To trust the certificate run 'dotnet dev-certs https --trust' (Windows and macOS only). For establishing trust on other platforms refer to the platform specific documentation.
For more information on configuring HTTPS see https://go.microsoft.com/fwlink/?linkid=848054.
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
- [x] [clist_end](CharacterScreen/Server/ClistEndPacketBase.cs)
- [x] [clist_start](CharacterScreen/Server/ClistStartPacketBase.cs)
- [x] [info](CharacterScreen/Server/InfoPacketBase.cs)
- [x] [OK](CharacterScreen/Server/OkPacketBase.cs)


## Game Packets (sent/received only in game)

### Sent by Client

- [x] [addobj](Game/Client/AddobjPacket.cs)
- [x] [b_i](Game/Client/BiPacket.cs)
- [x] [compl](Game/Client/ComplimentPacket.cs)
- [x] [dir](Game/Client/DirectionPacket.cs)
- [x] [drop](Game/Client/DropPacket.cs)
- [x] [eff](Game/Client/EffPacket.cs)
- [x] [eq](Game/Client/EqPacket.cs)
- [x] [eqinfo](Game/Client/EquipmentInfoPacket.cs)
- [x] [get](Game/Client/GetPacket.cs)
- [x] [glmk](Game/Client/CreateFamilyPacket.cs)
- [x] [gop](Game/Client/CharacterOptionPacket.cs)
- [x] [ivn](Game/Client/IvnPacket.cs)
- [x] [mlobj](Game/Client/MlObjPacket.cs)
- [x] [mvi](Game/Client/MviPacket.cs)
- [x] [ncif](Game/Client/NcifPacket.cs)
- [x] [pairy](Game/Client/PairyPacket.cs)
- [x] [put](Game/Client/PutPacket.cs)
- [x] [rmvobj](Game/Client/RmvobjPacket.cs)
- [x] [say](Game/Client/ClientSayPacket.cs)
- [x] [sc](Game/Client/ScPacket.cs)
- [x] [walk](Game/Client/WalkPacket.cs)
- [x] [wear](Game/Client/WearPacket.cs)


### Sent by Server

- [x] [at](Game/Server/AtPacketBase.cs)
- [x] [c_info](Game/Server/CInfoPacketBase.cs)
- [x] [c_map](Game/Server/CMapPacketBase.cs)
- [x] [c_mode](Game/Server/CModePacketBase.cs)
- [x] [cond](Game/Server/CondPacketBase.cs)
- [x] [fd](Game/Server/FdPacket.cs)
- [x] [gp](Game/Server/GpPacket.cs)
- [x] [in](Game/Server/InPacketBase.cs)
- [x] [in_alive_subpacket](Game/Server/InAliveSubPacketBase.cs)
- [x] [in_character_subpacket](Game/Server/InCharacterSubPacketBase.cs)
- [x] [in_item_subpacket](Game/Server/InItemSubPacketBase.cs)
- [x] [in_monster_subpacket](Game/Server/InMonsterSubPacket.cs)
- [x] [in_non_player_subpacket](Game/Server/InNonPlayerSubPacketBase.cs)
- [x] [in_ownable_subpacket](Game/Server/InOwnableSubPacket.cs)
- [x] [lev](Game/Server/LevPacket.cs)
- [x] [levelup](Game/Server/LevelUpPacket.cs)
- [x] [mv](Game/Server/MvPacket.cs)
- [x] [out](Game/Server/OutPacketBase.cs)
- [x] [remove](Game/Server/RemovePacket.cs)
- [x] [say](Game/Server/SayPacket.cs)
- [x] [st](Game/Server/StPacket.cs)
- [x] [stat](Game/Server/StatPacket.cs)
- [x] [tit](Game/Server/TitPacket.cs)
- [x] [u_i](Game/Server/UiPacket.cs)

