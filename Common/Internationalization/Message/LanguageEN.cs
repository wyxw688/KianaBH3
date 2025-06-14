namespace KianaBH.Internationalization.Message;

#region Root

public class LanguageEN
{
    public GameTextEN Game { get; } = new();
    public ServerTextEN Server { get; } = new();
    public WordTextEN Word { get; } = new(); // a placeholder for the actual word text
}

#endregion

#region Layer 1

/// <summary>
///     path: Game
/// </summary>
public class GameTextEN
{
    public CommandTextEN Command { get; } = new();
}

/// <summary>
///     path: Server
/// </summary>
public class ServerTextEN
{
    public WebTextEN Web { get; } = new();
    public ServerInfoTextEN ServerInfo { get; } = new();
}

/// <summary>
///     path: Word
/// </summary>
public class WordTextEN
{
    public string Rank => "Rank";
    public string Avatar => "Avatar";
    public string Material => "Material";
    public string Pet => "Pet";
    public string Relic => "Relic";
    public string Equipment => "Light Cone";
    public string Talent => "Talent";
    public string Banner => "Gacha";
    public string Activity => "Activity";
    public string CdKey => "CdKey";
    public string VideoKey => "VideoKey";
    public string Buff => "Blessing";
    public string Miracle => "Curio";
    public string Unlock => "Luxury";
    public string TrainParty => "TrainParty";

    // server info
    public string Config => "Config File";
    public string Language => "Language";
    public string Log => "Log";
    public string GameData => "Game Data";
    public string Cache => "Resource Cache";
    public string CustomData => "Custom Data";
    public string Database => "Database";
    public string Command => "Command";
    public string SSL => "SSL";
    public string Ec2b => "Ec2b";
    public string SdkServer => "Web Server";
    public string Handler => "Packet Handler";
    public string Dispatch => "Global Dispatch";
    public string Game => "Game";
    public string Handbook => "Handbook";
    public string NotFound => "Not Found";
    public string Error => "Error";
    public string FloorInfo => "Floor File";
    public string FloorGroupInfo => "Floor Group File";
    public string FloorMissingResult => "Teleportation and World Generation";
    public string FloorGroupMissingResult => "Teleportation, Monster Battles, and World Generation";
    public string Mission => "Mission";
    public string MissionInfo => "Mission File";
    public string SubMission => "Sub Mission";
    public string SubMissionInfo => "Sub Mission File";
    public string MazeSkill => "Maze Skill";
    public string MazeSkillInfo => "Maze Skill File";
    public string Dialogue => "Simulated Universe Event";
    public string DialogueInfo => "Simulated Universe Event File";
    public string Performance => "Performance";
    public string PerformanceInfo => "Performance File";
    public string RogueChestMap => "Simulated Universe Map";
    public string RogueChestMapInfo => "Simulated Universe Map File";
    public string ChessRogueRoom => "Simulated Universe DLC";
    public string ChessRogueRoomInfo => "Simulated Universe DLC File";
    public string SummonUnit => "Summon Unit";
    public string SummonUnitInfo => "Summon Unit File";
    public string RogueTournRoom => "Divergent Rogue Room";
    public string RogueTournRoomInfo => "Divergent Rogue Room File";
    public string TypesOfRogue => "types of rogue";
    public string RogueMagicRoom => "Unknowable Domain Room";
    public string RogueMagicRoomInfo => "Unknowable Domain Room File";
    public string RogueDiceSurface => "Dice Surface Effect";
    public string RogueDiceSurfaceInfo => "Dice Surface Effect File";
    public string AdventureModifier => "AdventureModifier";
    public string AdventureModifierInfo => "AdventureModifier File";
    public string RogueMapGen => "RogueMapGen File";
    public string RogueMiracleGroup => "RogueMiracleGroup File";
    public string RogueMiracleEffectGen => "RogueMiracleEffectGen File";

    public string DatabaseAccount => "Database Account";
    public string Tutorial => "Tutorial";
}

#endregion

#region Layer 2

#region GameText

/// <summary>
///     path: Game.Command
/// </summary>
public class CommandTextEN
{
    public NoticeTextEN Notice { get; } = new();

    public GenderTextEN Gender { get; } = new();
    public AvatarTextEN Avatar { get; } = new();
    public AnnounceTextEN Announce { get; } = new();
    public BanTextEN Ban { get; } = new();
    public GiveTextEN Give { get; } = new();
    public GiveAllTextEN GiveAll { get; } = new();
    public LineupTextEN Lineup { get; } = new();
    public HelpTextEN Help { get; } = new();
    public KickTextEN Kick { get; } = new();
    public MissionTextEN Mission { get; } = new();
    public RelicTextEN Relic { get; } = new();
    public ReloadTextEN Reload { get; } = new();
    public RogueTextEN Rogue { get; } = new();
    public SceneTextEN Scene { get; } = new();
    public UnlockAllTextEN UnlockAll { get; } = new();
    public MailTextEN Mail { get; } = new();
    public RaidTextEN Raid { get; } = new();
    public AccountTextEN Account { get; } = new();
    public UnstuckTextEN Unstuck { get; } = new();
    public SetlevelTextEN Setlevel { get; } = new();
    public PermissionTextEN Permission { get; } = new();
    public RemoveItemTextEN RemoveItem { get; } = new();
    public SkipTextEN Skip { get; } = new();
}

#endregion

#region ServerTextEN

/// <summary>
///     path: Server.Web
/// </summary>
public class WebTextEN
{
    public string Maintain => "The server is undergoing maintenance, please try again later.";
}

/// <summary>
///     path: Server.ServerInfo
/// </summary>
public class ServerInfoTextEN
{
    public string Shutdown => "Shutting down...";
    public string CancelKeyPressed => "Cancel key pressed (Ctrl + C), server shutting down...";
    public string StartingServer => "Starting KianaBH";
    public string CurrentVersion => "Server supported versions: {0}";
    public string InvalidVersion => "Unsupported game version {0}\nPlease update game to {1}";
    public string LoadingItem => "Loading {0}...";
    public string GeneratingItem => "Building {0}...";
    public string WaitingItem => "Waiting for process {0} to complete...";
    public string RegisterItem => "Registered {0} {1}(s).";
    public string FailedToLoadItem => "Failed to load {0}.";
    public string NewClientSecretKey => "Client Secret Key does not exist and a new Client Secret Key is being generated.";
    public string FailedToInitializeItem => "Failed to initialize {0}.";
    public string FailedToReadItem => "Failed to read {0}, file {1}";
    public string GeneratedItem => "Generated {0}.";
    public string LoadedItem => "Loaded {0}.";
    public string LoadedItems => "Loaded {0} {1}(s).";
    public string ServerRunning => "{0} server listening on {1}";

    public string ServerStarted =>
        "Startup complete! Took {0}s, better than 99% of users. Type 'help' for command help"; // This is a meme, consider localpermissiong in English

    public string MissionEnabled =>
        "Mission system enabled. This feature is still in development and may not work as expected. Please report any bugs to the developers.";
    public string KeyStoreError => "The SSL certificate does not exist, SSL functionality has been disabled.";
    public string CacheLoadSkip => "Skipped cache loading.";

    public string ConfigMissing => "{0} is missing. Please check your resource folder: {1}, {2} may not be available.";
    public string UnloadedItems => "Unloaded all {0}.";
    public string SaveDatabase => "Database saved in {0}s";

    public string WaitForAllDone =>
        "You cannot enter the game yet. Please wait for all items to load before trying again";

    public string UnhandledException => "An unhandled exception occurred: {0}";
}

#endregion

#endregion

#region Layer 3

#region CommandText

/// <summary>
///     path: Game.Command.Notice
/// </summary>
public class NoticeTextEN
{
    public string PlayerNotFound => "Player tidak ditemukan!";
    public string InvalidArguments => "Argumen command ngawur!";
    public string NoPermission => "Ga ada akses buat make command ini!";
    public string CommandNotFound => "Ga ketemu itu command. Ketik '/help' untuk cek command yang ada.";
    public string TargetNotFound => "Target {0} tidak ditemukan!";
    public string TargetOffline => "Target {0}({1}) lagi offline! Target akan di clear.";
    public string TargetFound => "Online player {0}({1}) ditemukan, command selanjutnya bakal target dia secara default.";
    public string InternalError => "Error menjalankan command! {0}";
}

/// <summary>
///     path: Game.Command.Gender
/// </summary>
public class GenderTextEN
{
    public string Desc => "Ganti gender & path";
    public string Usage => "Pengunaan: /gender [man/woman] [id path]";
    public string GenderNotSpecified => "Gender tidak ditemukan!";
    public string GenderChanged => "Gender telah diganti!";
}

/// <summary>
///     path: Game.Command.UnlockAll
/// </summary>
public class UnlockAllTextEN
{
    public string Desc =>
        "Sesuai nama, unlock semuanya." +
        "'/unlockall mission' buat finish all missions. Nanti bakal di kick setelah jalanin. Ada kemungkinan bakal stuck di tutorial, gunakan dengan hati-hati" +
        "'/unlockall tutorial' buat unlock all tutorials.  Nanti bakal di kick setelah jalanin. Dipakai untuk ketika stuck in some pages\n" +
        "'/unlockall rogue' buat unlock all rogue types. Nanti bakal di kick setelah jalanin. Pakai bersamaan dengan '/unlockall tutorial' untuk dapatkan performance yg lebih baik";
    public string Usage => "Penggunaan: /unlockall [mission/tutorial/rogue]";
    public string UnlockedAll => "Unlocked All {0}!";
}

/// <summary>
///     path: Game.Command.Avatar
/// </summary>
public class AvatarTextEN
{
    public string Desc => "Set properti untuk karakter yang dimiliki. Untuk target semua karakter, set Avatar ID ke -1 ya!";
    public string Usage =>
        "Penggunaan: /avatar talent [Avatar ID/-1] [Talent Level]\n" +
        "Penggunaan: /avatar rank [Avatar ID/-1] [Rank]\n" +
        "Penggunaan: /avatar level [Avatar ID/-1] [Avatar Level]";
    public string InvalidLevel => "Invalid {0} level!";
    public string AllAvatarsLevelSet => "Semua karakter {0}nya telah di set ke level {1}.";
    public string AvatarLevelSet => "Karakter {0} {1}nya telah di set ke level {2}";
    public string AvatarNotFound => "Karakter tidak ditemukan!";
}

/// <summary>
///     path: Game.Command.Give
/// </summary>
public class GiveTextEN
{
    public string Desc => "Untuk memberi item ke player. Jangan pakai ini untuk relic.";
    public string Usage => "Penggunaan: /give [item ID] l[level] x[jumlah] r[rank]";
    public string ItemNotFound => "Item tidak ditemukan!";
    public string GiveItem => "Telah diberi {0} {1} item {2}.";
}

/// <summary>
///     path: Game.Command.GiveAll
/// </summary>
public class GiveAllTextEN
{
    public string Desc => "Untuk memberi player semua jenis item.";
    public string Usage =>
        "Penggunaan: /giveall avatar r[rank] l[level]\n" +
        "Penggunaan: /giveall material x[jumlah]\n" +
        "Penggunaan: /giveall equipment r[rank] l[level] x[jumlah]\n" +
        "Penggunaan: /giveall relic x[jumlah]\n" +
        "Penggunaan: /giveall unlock\n" +
        "Penggunaan: /giveall train\n" +
        "Penggunaan: /giveall path";
    public string GiveAllItems => "Telah diberikan semua {0}, masing-masing berjumlah {1}";
}

/// <summary>
///     path: Game.Command.Lineup
/// </summary>
public class LineupTextEN
{
    public string Desc => "Atur properti overworld lineup. Mp = tech point, Sp = energy, heal ya heal.";
    public string Usage =>
        "Penggunaan: /lineup mp\n" +
        "Penggunaan: /lineup sp\n" +
        "Penggunaan: /lineup heal";
    public string GainedMp => "Player telah diberikan tech points!";
    public string GainedSp => "Player telah diberikan energy!";
    public string HealedAllAvatars => "Satu lineup telah di heal!";
}

/// <summary>
///     path: Game.Command.Help
/// </summary>
public class HelpTextEN
{
    public string Desc => "Show help information";
    public string Usage =>
        "Penggunaan: /help\n" +
        "Penggunaan: /help [cmd]";
    public string Commands => "Commands: ";
    public string CommandUsage => "Penggunaan: ";
    public string CommandPermission => "Level Permission Untuk Akses: ";
    public string CommandAlias => "Command Alias：";
}

/// <summary>
///     path: Game.Command.Kick
/// </summary>
public class KickTextEN
{
    public string Desc => "Kick out player";
    public string Usage => "Penggunaan: /kick";
    public string PlayerKicked => "Player {0} telah di kick!";
}

/// <summary>
///     path: Game.Command.Mission
/// </summary>
public class MissionTextEN
{
    public string Desc =>
        "Mengelola misi pemain\n" +
        "Gunakan 'pass' untuk menyelesaikan semua misi yang sedang berjalan, perintah ini dapat menyebabkan lag yang parah, harap gunakan '/mission finish' sebagai gantinya\n" +
        "Gunakan 'finish [SubMissionID]' untuk menyelesaikan sub-misi tertentu, silakan cari ID sub-misi di buku panduan\n" +
        "Gunakan 'finishmain [MainMissionID]' untuk menyelesaikan misi utama tertentu, silakan cari ID misi utama di buku panduan\n" +
        "Gunakan 'running <-all>' untuk melihat misi yang sedang dilacak, menambahkan '-all' akan menampilkan semua misi yang sedang berjalan dan kemungkinan misi yang macet, setelah digunakan, daftar misi yang lebih panjang mungkin muncul, harap diperhatikan\n" +
        "Gunakan 'reaccept' untuk menerima kembali misi utama tertentu, silakan cari ID misi utama di buku panduan";
    
    public string Usage =>
        "Penggunaan: /mission pass\n" +
        "Penggunaan: /mission finish [ID Sub Misi]\n" +
        "Penggunaan: /mission running\n" +
        "Penggunaan: /mission reaccept [ID Misi Utama]\n" +
        "Penggunaan: /mission finishmain [ID Misi Utama]";
    
    public string AllMissionsFinished => "Semua tugas telah diselesaikan!";
    public string AllRunningMissionsFinished => "Sebanyak {0} tugas yang sedang berjalan telah diselesaikan!";
    public string MissionFinished => "Tugas {0} telah diselesaikan!";
    public string InvalidMissionId => "ID tugas tidak valid!";
    public string NoRunningMissions => "Tidak ada tugas yang sedang berjalan!";
    public string RunningMissions => "Tugas yang sedang berjalan: ";
    public string PossibleStuckMissions => "Tugas yang kemungkinan macet: ";
    public string MainMission => "Tugas utama";
    public string MissionReAccepted => "Tugas {0} telah diterima kembali!";
}


/// <summary>
///     path: Game.Command.Relic
/// </summary>
public class RelicTextEN
{
    public string Desc => "Mengelola relic pemain, Batas level: 1 ≤ Level ≤ 9999";
    public string Usage => 
        "Penggunaan: /relic [ID relic] [ID main affix] [ID sub affix:jumlah roll] l[level] x[jumlah]\n" +
        "Catatan:\n" +
        "- 'ID sub affix:jumlah roll' dapat diulang hingga 4 kali.\n" +
        "- Jika tidak diberikan, sub affix akan dipilih secara acak.";
    public string RelicNotFound => "Relic tidak ditemukan!";
    public string InvalidMainAffixId => "ID main affix tidak valid!";
    public string InvalidSubAffixId => "ID sub affix tidak valid!";
    public string RelicGiven => "Memberikan kepada pemain @{0} {1} relic {2}, main affix {3}.";
}


/// <summary>
///     path: Game.Command.Reload
/// </summary>
public class ReloadTextEN
{
    public string Desc => "Muat ulang konfigurasi yang ditentukan";
    public string Usage => "Penggunaan: /reload [banner/activity]";
    public string ConfigReloaded => "Konfigurasi {0} telah dimuat ulang!";
}

/// <summary>
///     path: Game.Command.Rogue
/// </summary>
public class RogueTextEN
{
    public string Desc => "Command ini tidak work. Digunakan untuk mengelola data pemain dalam simulated universe, -1 berarti semua blessing, 'buff' untuk mendapatkan blessing, 'enhance' untuk meningkatkan blessing";
    public string Usage =>
        "Penggunaan: /rogue money [Jumlah Universe Debris]\n" +
        "Penggunaan: /rogue buff [ID blessing/-1]\n" +
        "Penggunaan: /rogue miracle [ID miracle]\n" +
        "Penggunaan: /rogue enhance [ID blessing/-1]\n" +
        "Penggunaan: /rogue unstuck - Keluar dari event";
    public string PlayerGainedMoney => "Pemain mendapatkan {0} universe debris.";
    public string PlayerGainedAllItems => "Pemain mendapatkan semua {0}.";
    public string PlayerGainedItem => "Pemain mendapatkan {0} {1}.";
    public string PlayerEnhancedBuff => "Pemain meningkatkan blessing {0}.";
    public string PlayerEnhancedAllBuffs => "Pemain meningkatkan semua blessing.";
    public string PlayerUnstuck => "Pemain keluar dari event.";
    public string NotFoundItem => "{0} tidak ditemukan!";
    public string PlayerNotInRogue => "Pemain tidak berada dalam simulated universe!";
}

/// <summary>
///     path: Game.Command.Scene
/// </summary>
public class SceneTextEN
{
    public string Desc =>
        "Mengelola scene pemain\n" +
        "Catatan: Sebagian besar perintah dalam grup ini digunakan untuk debugging. Pastikan Anda memahami apa yang Anda lakukan sebelum menggunakan perintah apa pun.\n" +
        "Gunakan 'prop' untuk mengatur status sebuah prop. Untuk daftar status, lihat Common/Enums/Scene/PropStateEnum.cs\n" +
        "Gunakan 'unlockall' untuk membuka semua prop dalam scene (misalnya, mengatur semua prop yang dapat dibuka ke status 'open'). Perintah ini dapat menyebabkan game terhenti di 90% saat memuat. Gunakan '/scene reset <floorId>' untuk mengatasi masalah ini.\n" +
        "Gunakan 'change' untuk memasuki scene tertentu. Untuk EntryId, lihat Resources/MapEntrance.json\n" +
        "Gunakan 'reload' untuk memuat ulang scene saat ini dan kembali ke posisi awal.\n" +
        "Gunakan 'reset' untuk mengatur ulang status semua prop dalam scene yang ditentukan. Untuk mengetahui FloorId saat ini, gunakan '/scene cur'.";

    public string Usage =>
        "Penggunaan: /scene [entry id]\n" +
        "Penggunaan: /scene cur\n" +
        "Penggunaan: /scene reload\n" +
        "Penggunaan: /scene group\n" +
        "Penggunaan: /scene unlockall\n" +
        "Penggunaan: /scene reset [floor id]\n" +
        "Penggunaan: /scene prop [group id] [prop id] [state]\n" +
        "Penggunaan: /scene remove [entity id]\n";
    public string LoadedGroups => "Grup yang dimuat: {0}.";
    public string PropStateChanged => "Prop: {0} diatur ke status {1}.";
    public string PropNotFound => "Prop tidak ditemukan!";
    public string EntityRemoved => "Entity {0} telah dihapus.";
    public string EntityNotFound => "Entity tidak ditemukan!";
    public string AllPropsUnlocked => "Semua prop telah dibuka!";
    public string SceneChanged => "Memasuki scene {0}.";
    public string SceneReloaded => "Scene telah dimuat ulang!";
    public string SceneReset => "Status prop di floor {0} telah direset!";
    public string CurrentScene => "Scene saat ini Entry Id: {0}, Plane Id: {1}, Floor Id: {2}.";
}

/// <summary>
///     path: Game.Command.Mail
/// </summary>
public class MailTextEN
{
    public string Desc => "Mengelola mail pemain";
    public string Usage => "Penggunaan: /mail [namaPengirim] [judul] [isi] [ID1:jumlah,ID2:jumlah]";
    public string MailSent => "Surat telah dikirim!";
}

/// <summary>
///     path: Game.Command.Raid
/// </summary>
public class RaidTextEN
{
    public string Desc => "Mengelola scene sementara pemain";
    public string Usage => "Penggunaan: /raid leave";
    public string Leaved => "Keluar dari scene sementara!";
}

/// <summary>
///     path: Game.Command.Account
/// </summary>
public class AccountTextEN
{
    public string Desc => "Mengelola akun database";
    public string Usage =>
        "Penggunaan: /account create [username] [UID] [password]\n" +
        "Penggunaan: /account delete [UID]";
    public string InvalidUid => "Argumen UID tidak valid!";
    public string InvalidAccount => "Akun {0} tidak valid!";
    public string CreateSuccess => "Akun {0} berhasil dibuat!";
    public string DeleteSuccess => "Akun {0} berhasil dihapus!";
}

/// <summary>
///     path: Game.Command.Announce
/// </summary>
public class AnnounceTextEN
{
    public string Desc => "Mengirim pengumuman sistem pusat";
    public string Usage => "Penggunaan: /announce [Teks] [Warna]";
    public string SendSuccess => "Pengumuman berhasil dikirim!";
}

/// <summary>
///     path: Game.Command.Ban
/// </summary>
public class BanTextEN
{
    public string Desc => "Blokir atau buka blokir pengguna";
    public string Usage => "Penggunaan: /ban [add/delete]";
    public string BanSuccess => "Akun telah diblokir!";
    public string UnBanSuccess => "Akun telah dibuka blokirnya!";
}

/// <summary>
///     path: Game.Command.Unstuck
/// </summary>
public class UnstuckTextEN
{
    public string Desc => "Teleport pemain kembali ke lokasi default";
    public string Usage => "Penggunaan: /unstuck [UID]";
    public string UnstuckSuccess => "Berhasil memindahkan pemain kembali ke lokasi default.";
    public string UidNotExist => "UID tidak ditemukan!";
    public string PlayerIsOnline => "Pemain sedang online!";
}

/// <summary>
///     path: Game.Command.Setlevel
/// </summary>
public class SetlevelTextEN
{
    public string Desc => "Mengatur level pemain";
    public string Usage => "Penggunaan: /setlevel [Level]";
    public string SetlevelSuccess => "Berhasil mengatur level pemain!";
}

/// <summary>
///     path: Game.Command.Permission
/// </summary>
public class PermissionTextEN
{
    public string Desc => "Mengelola permission pemain";
    public string Usage =>
        "Penggunaan: /permission add [permission]\n" +
        "Penggunaan: /permission remove [permission]\n" +
        "Penggunaan: /permission clean [permission]";
    public string InvalidPerm => "Permission {0} tidak ditemukan!";
    public string Added => "Menambahkan permission {0} ke pemain {1}!";
    public string Removed => "Menghapus permission {1} dari pemain {0}!";
    public string Cleaned => "Menghapus semua permission dari pemain {0}!";
}

/// <summary>
///     path: Game.Command.RemoveItem
/// </summary>
public class RemoveItemTextEN
{
    public string Desc => "Menghapus Relic atau Lightcone";
    public string Usage =>
        "Penggunaan: /remove relic\n" +
        "Penggunaan: /remove lightcone";
    public string InvalidPerm => "Permission {0} tidak ditemukan!";
    public string RemovedRelics => "Relic telah dihapus dari pemain {0}!";
    public string RemovedLightcones => "Lightcone telah dihapus dari pemain {0}!";
}

/// <summary>
///     path: Game.Command.Skip
/// </summary>
public class SkipTextEN
{
    public string Desc => "Skip 1st half MOC / PF / AS dan langsung ke 2nd half";
    public string Usage => "Penggunaan: /skip" ;
    public string Success => "Berhasil menyetel skip 1st half ke {0}!";
}


#endregion

#endregion