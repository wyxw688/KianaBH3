using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dorm;

public class PacketGetDormDataRsp : BasePacket
{
    public PacketGetDormDataRsp() : base(CmdIds.GetDormDataRsp)
    {
        // TODO: Hardcoded
        var proto = new GetDormDataRsp
        {
            DepotFurnitureList =
            {
                new DepotFurniture { Id = 140001, Num = 1 },
                new DepotFurniture { Id = 140002, Num = 1 },
                new DepotFurniture { Id = 140003, Num = 1 },
                new DepotFurniture { Id = 140010, Num = 1 },
                new DepotFurniture { Id = 140012, Num = 1 },
                new DepotFurniture { Id = 140013, Num = 1 },
                new DepotFurniture { Id = 140015, Num = 1 },
                new DepotFurniture { Id = 140016, Num = 1 },
                new DepotFurniture { Id = 140201, Num = 1 },
                new DepotFurniture { Id = 140202, Num = 1 },
                new DepotFurniture { Id = 140213, Num = 1 },
                new DepotFurniture { Id = 140215, Num = 1 },
                new DepotFurniture { Id = 140216, Num = 1 },
                new DepotFurniture { Id = 140601, Num = 1 },
                new DepotFurniture { Id = 140603, Num = 1 },
                new DepotFurniture { Id = 140801, Num = 1 },
                new DepotFurniture { Id = 140802, Num = 1 },
                new DepotFurniture { Id = 140806, Num = 1 },
                new DepotFurniture { Id = 140810, Num = 1 },
                new DepotFurniture { Id = 140812, Num = 1 },
                new DepotFurniture { Id = 140813, Num = 1 },
                new DepotFurniture { Id = 140814, Num = 1 },
                new DepotFurniture { Id = 140815, Num = 1 },
                new DepotFurniture { Id = 140816, Num = 1 },
                new DepotFurniture { Id = 140817, Num = 1 },
                new DepotFurniture { Id = 140818, Num = 1 },
                new DepotFurniture { Id = 140819, Num = 1 },
                new DepotFurniture { Id = 140820, Num = 1 },
                new DepotFurniture { Id = 140822, Num = 1 },
                new DepotFurniture { Id = 141501, Num = 1 },
                new DepotFurniture { Id = 141601, Num = 1 },
                new DepotFurniture { Id = 141606, Num = 1 },
                new DepotFurniture { Id = 141615, Num = 1 },
                new DepotFurniture { Id = 141619, Num = 1 },
                new DepotFurniture { Id = 141620, Num = 1 },
                new DepotFurniture { Id = 141621, Num = 1 },
                new DepotFurniture { Id = 141622, Num = 1 },
                new DepotFurniture { Id = 141701, Num = 1 },
                new DepotFurniture { Id = 141702, Num = 1 },
                new DepotFurniture { Id = 141703, Num = 1 },
                new DepotFurniture { Id = 141704, Num = 1 },
                new DepotFurniture { Id = 141709, Num = 1 },
                new DepotFurniture { Id = 141713, Num = 1 },
                new DepotFurniture { Id = 141801, Num = 1 },
                new DepotFurniture { Id = 141802, Num = 1 },
                new DepotFurniture { Id = 141804, Num = 1 },
                new DepotFurniture { Id = 141805, Num = 1 },
                new DepotFurniture { Id = 141807, Num = 1 },
                new DepotFurniture { Id = 141808, Num = 1 },
                new DepotFurniture { Id = 141809, Num = 1 },
                new DepotFurniture { Id = 141810, Num = 1 },
                new DepotFurniture { Id = 141811, Num = 1 },
                new DepotFurniture { Id = 141812, Num = 1 },
                new DepotFurniture { Id = 141814, Num = 1 },
                new DepotFurniture { Id = 141815, Num = 1 },
                new DepotFurniture { Id = 146120, Num = 1 },
                new DepotFurniture { Id = 146620, Num = 1 }
            },
            EventList =
            {
                new DormEvent { AvatarId = 101, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 102, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 103, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 104, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 105, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 106, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 111, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 112, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 113, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 114, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 201, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 202, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 203, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 204, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 205, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 206, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 211, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 212, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 213, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 214, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 301, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 302, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 303, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 311, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 312, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 313, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 314, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 317, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 401, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 402, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 403, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 404, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 411, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 412, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 421, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 422, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 501, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 502, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 503, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 504, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 506, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 507, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 511, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 601, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 602, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 603, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 604, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 611, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 612, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 702, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 703, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 705, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 706, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 711, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 712, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 713, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 714, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 801, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 802, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 803, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2201, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2202, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2401, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2501, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2601, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2801, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2901, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 2902, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 3101, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 3201, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 3301, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 3501, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 3601, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 3701, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 20201, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 20301, EventIdList = { 10007, 10011 } },
                new DormEvent { AvatarId = 20401, EventIdList = { 10007, 10011 } }
            },
            HouseList =
            {
                new DormHouse
                {
                    Id = 101,
                    Level = 39,
                    Name = "HitLey",
                    RoomList =
                    {
                        new DormRoom
                        {
                            AvatarList = { 412, 705, 802, 2201, 2401 },
                            FurnitureList =
                            {
                                new Furniture { Id = 140015 },
                                new Furniture { Id = 140013 },
                                new Furniture { Id = 140016 }
                            },
                            Id = 1011
                        },
                        new DormRoom
                        {
                            AvatarList = { 105, 113, 205, 313, 612 },
                            FurnitureList =
                            {
                                new Furniture { Id = 140808, PosX = 1, PosY = 22 },
                                new Furniture { Id = 140809, Location = 3, PosX = 7, PosY = 5 },
                                new Furniture { Direction = 3, Id = 140803, PosX = 1, PosY = 15 },
                                new Furniture { Direction = 1, Id = 140811, PosX = 5, PosY = 14 },
                                new Furniture { Id = 141610, PosX = 2, PosY = 8 },
                                new Furniture { Id = 140812, PosX = 4, PosY = 4 },
                                new Furniture { Id = 141806, PosX = 9, PosY = 7 },
                                new Furniture { Id = 141803, PosX = 11, PosY = 12 },
                                new Furniture { Id = 140821, Location = 2, PosX = 7, PosY = 3 },
                                new Furniture { Id = 140002, PosX = 26, PosY = 2 },
                                new Furniture { Id = 140804, PosX = 24, PosY = 17 },
                                new Furniture { Id = 140805, PosX = 25, PosY = 15 },
                                new Furniture { Id = 140807, PosX = 23, PosY = 5 },
                                new Furniture { Id = 140825 },
                                new Furniture { Id = 140824 },
                                new Furniture { Id = 140823 }
                            },
                            Id = 1012
                        },
                        new DormRoom
                        {
                            FurnitureList =
                            {
                                new Furniture { Id = 140015 },
                                new Furniture { Id = 140013 },
                                new Furniture { Id = 140016 }
                            },
                            Id = 1013
                        }
                    }
                }
            },
            IsAllowVisit = true,
            ShowHouse = 101,
            ShowRoom = 1012,
            VisitAvatar = 101
        };

        SetData(proto);
    }
}
