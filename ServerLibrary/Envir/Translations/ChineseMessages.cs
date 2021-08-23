using Library;

namespace Server.Envir.Translations
{
    [ConfigPath(@".\Translations\ChineseMessages.ini")]
    public class ChineseMessages : StringMessages
    {
        public override string BannedWrongPassword { get; set; } = "密码多次输入错误.";


        public override string PaymentComplete { get; set; } = "你成功购买了 {0} 元宝.";
        public override string PaymentFailed { get; set; } = "你因为支付失败被扣除了{0}元宝.";
        public override string ReferralPaymentComplete { get; set; } = "你推荐的一个用户刚刚购买了元宝，你因此获得了{0}赏金的奖励.";
        public override string ReferralPaymentFailed { get; set; } = "你所推荐的一个用户的元宝购买因为支付失败，你失去了之前获得的{0}赏金奖励.";
        public override string GameGoldLost { get; set; } = "你被移除了{0}的元宝.";
        public override string GameGoldRefund { get; set; } = "你获得了{0}元宝的返还.";
        public override string HuntGoldRefund { get; set; } = "你获得了{0}赏金的返还.";


        public override string Welcome { get; set; } = "欢迎来到Zircon服务器.";
        public override string WelcomeObserver { get; set; } = "你正在使用观察者模式观看{0}的视角，想要退出观察者模式请退出登录.";
        public override string ObserverChangeFail { get; set; } = "你只能在安全区能设置自己是否允许他人观看你的视角";
        public override string OnlineCount { get; set; } = "当前在线人数:{0}, 观察者在线人数:{1}";
        public override string ObserverCount { get; set; } = "现在有{0}个观察者正在观看你的视角.";
        public override string CannotFindPlayer { get; set; } = "无法找到角色:{0}";
        public override string AlreadyBlocked { get; set; } = "{0} is already on your block list.";
        public override string BlockingWhisper { get; set; } = "You are blocking Whispers.";
        public override string PlayerBlockingWhisper { get; set; } = "Player: {0} is blocking Whispers.";
        public override string GlobalDelay { get; set; } = "You cannot global for another {0} seconds.";
        public override string GlobalLevel { get; set; } = "You need to be level 33 before you can global shout.";
        public override string ShoutDelay { get; set; } = "You cannot shout for another {0} seconds.";
        public override string ShoutLevel { get; set; } = "You need to be level 2 before you can shout.";
        public override string DiceRoll { get; set; } = "[ROLL] - {0} has rolled {1} on a {2} sided dice.";
        public override string TradingEnabled { get; set; } = "交易开启.";
        public override string TradingDisabled { get; set; } = "交易关闭.";
        public override string WhisperEnabled { get; set; } = "私聊开启.";
        public override string WhisperDisabled { get; set; } = "私聊关闭.";
        public override string GuildInviteEnabled { get; set; } = "允许加入行会.";
        public override string GuildInviteDisabled { get; set; } = "禁止加入行会.";
        public override string ObserverNotLoggedIn { get; set; } = "你需要登录账户才能在观察者模式下聊天";
        public override string Poisoned { get; set; } = "你中毒了.";
        public override string MurderedBy { get; set; } = "你被{0}杀死了.";
        public override string Curse { get; set; } = "你杀死了{0},厄运将伴随你...";
        public override string Murdered { get; set; } = "你杀死了{0}.";
        public override string Protected { get; set; } = "你收到正当防卫规则的保护.";
        public override string Killed { get; set; } = "你被{0}的正当防卫所击杀.";
        public override string Died { get; set; } = "你在战斗中阵亡了.";
        public override string GroupRecallEnabled { get; set; } = "组队召唤已启用.";
        public override string GroupRecallDisabled { get; set; } = "组队召唤已禁用.";
        public override string NoActionOnInstance { get; set; } = "Cannot perform this action whilst on an instance.";
        

        public override string NeedLevel { get; set; } = "你需要达到{0}等级才能进入.";
        public override string NeedMaxLevel { get; set; } = "你需要等级 {0} 或更低才能继续.";
        public override string NeedItem { get; set; } = "你需要等级'{0}'才能进入.";
        public override string NeedMonster { get; set; } = "入口被封印了...";
        public override string NeedClass { get; set; } = "非{0}禁止入内.";


        public override string ConquestStarted { get; set; } = "{0}攻城战开始了.";
        public override string ConquestFinished { get; set; } = "{0}攻城战结束了.";
        public override string ConquestCapture { get; set; } = "{0}占领了{1}.";
        public override string ConquestOwner { get; set; } = "{0} 是{1}的占领者.";
        public override string ConquestLost { get; set; } = "{0}失去了{1}.";


        public override string BossSpawn { get; set; } = "Boss在{0}刷新了.";
        public override string HarvestRare { get; set; } = "有价值的珍稀物品需要在 {0} 的尸体里挖取.";
        public override string NetherGateOpen { get; set; } = "通往幽灵船的门开启了，坐标{0}, {1}";
        public override string NetherGateClosed { get; set; } = "通往幽灵船的门关闭了";
        public override string HarvestNothing { get; set; } = "没有获得任何物品.";
        public override string HarvestCarry { get; set; } = "你无法再装载任何物品.";
        public override string HarvestOwner { get; set; } = "你无法挖取当前怪物尸体.";
        public override string LairGateOpen { get; set; } = "通往地狱的大门已经打开, {0}, {1}";
        public override string LairGateClosed { get; set; } = "通往地狱的大门已经关闭";


        public override string Expired { get; set; } = "你的{0}物品失效了.";
        public override string CannotTownTeleport { get; set; } = "无法传送到该地图.";
        public override string CannotRandomTeleport { get; set; } = "当前地图无法使用随机传送卷.";
        public override string ConnotResetCompanionSkill { get; set; } = "为了避免误操作，请输入'@宠物等级{1}'来使用{0}";
        public override string LearnBookFailed { get; set; } = "技能书页数不足，修行技能失败了";
        public override string LearnBookSuccess { get; set; } = "恭喜你成功修行了{0}技能.";
        public override string LearnBook4Failed { get; set; } = "未能学习4级技能.";
        public override string LearnBook4Success { get; set; } = "恭喜，你已成功学习4级 {0}.";
        public override string StorageSafeZone { get; set; } = "你无法在非安全区使用仓库.";
        public override string GuildStoragePermission { get; set; } = "你没有从行会仓库取出物品的权限";
        public override string GuildStorageSafeZone { get; set; } = "你无法在非安全区使用行会仓库";
        public override string CompanionNoRoom { get; set; } = "你的宠物已经无法携带更多物品";
        public override string StorageLimit { get; set; } = "你无法再扩展存储空间.";


        public override string MarryAlreadyMarried { get; set; } = "You are already married.";
        public override string MarryNeedLevel { get; set; } = "You need to be atleast level 22 to get married.";
        public override string MarryNeedGold { get; set; } = "You do not have the 500,000 Gold required to pay for this service.";
        public override string MarryNotFacing { get; set; } = "You need to be facing another player to propose.";
        public override string MarryTargetAlreadyMarried { get; set; } = "{0} is already married.";
        public override string MarryTargetHasProposal { get; set; } = "{0} already has a marriage proposal.";
        public override string MarryTargetNeedLevel { get; set; } = "{0} needs to be atleast level 22 to get married.";
        public override string MarryTargetNeedGold { get; set; } = "{0} cannot afford to get married to you.";
        public override string MarryDead { get; set; } = "You cannot marry a dead person.";
        public override string MarryComplete { get; set; } = "Congratulations, you're now married to {0}.";
        public override string MarryDivorce { get; set; } = "You have divorced {0}";
        public override string MarryDivorced { get; set; } = "{0} has divorced you.";
        public override string MarryTeleportDead { get; set; } = "You cannot teleport to your partner you are dead.";
        public override string MarryTeleportPK { get; set; } = "You cannot teleport to your partner you are Red.";
        public override string MarryTeleportDelay { get; set; } = "You cannot teleport to your partner for another {0}.";
        public override string MarryTeleportOffline { get; set; } = "You cannot teleport to your partner whilst they are offline.";
        public override string MarryTeleportPartnerDead { get; set; } = "You cannot teleport to your partner whilst they are dead.";
        public override string MarryTeleportMap { get; set; } = "You cannot teleport to your partner on that map.";
        public override string MarryTeleportMapEscape { get; set; } = "You cannot use marraige teleport on this map.";


        public override string CompanionAppearanceAlready { get; set; } = "宠物{0}的外观已经能够获取.";
        public override string CompanionNeedTicket { get; set; } = "你需要在商城购买一张宠物外观解锁票来解锁这一宠物外观再进行购买该宠物.";
        public override string CompanionSkillEnabled { get; set; } = "宠物可以使用{0}级的技能.";
        public override string CompanionSkillDisabled { get; set; } = "宠物不能使用{0}级的技能.";
        public override string CompanionAppearanceLocked { get; set; } = "{0}的宠物外观目前尚未解锁，你无法购买，你需要在商城购买一张宠物外观解锁票来解锁这一宠物外观再进行购买该宠物.";
        public override string CompanionNeedGold { get; set; } = "当前金币不足，无法购买宠物.";
        public override string CompanionBadName { get; set; } = "该名称不符合宠物命名的规则.";
        public override string CompanionRetrieveFailed { get; set; } = "无法获得{0}宠物，该宠物当前跟随着{1}.";
        public override string QuestSelectReward { get; set; } = "你必须选择任务奖励";
        public override string QuestNeedSpace { get; set; } = "你背包的空间不足，无法完成任务并领取奖励.";


        public override string MailSafeZone { get; set; } = "Unable to get item from mail, you are not in a safe zone.";
        public override string MailNeedSpace { get; set; } = "Unable to get item from mail, not enough space.";
        public override string MailHasItems { get; set; } = "Unable to delete mail that contains items.";
        public override string MailNotFound { get; set; } = "{0} does not exist.";
        public override string MailSelfMail { get; set; } = "You cannot send mail to yourself.";
        public override string MailMailCost { get; set; } = "You cannot afford to send this mail.";
        public override string MailSendSafeZone { get; set; } = "You cannot send items from your inventory if you are not in SafeZone";


        public override string ConsignSafeZone { get; set; } = "You cannot Consign items from your inventory outside of safezone";
        public override string ConsignLimit { get; set; } = "You have reached the maximum number of Consignments";
        public override string ConsignGuildFundsGuild { get; set; } = "你还没有加入行会，无法使用行会资金从寄售购买物品.";
        public override string ConsignGuildFundsPermission { get; set; } = "你没有足够的权限使用行会资金.";
        public override string ConsignGuildFundsCost { get; set; } = "行会资金不足.";
        public override string ConsignGuildFundsUsed { get; set; } = "使用了{1:#,##0} 行会资金在寄售商以单价{4}寄售了{2} x{3}.";
        public override string ConsignCost { get; set; } = "你的金币不足.";
        public override string ConsignComplete { get; set; } = "Item registered successfully.";
        public override string ConsignAlreadySold { get; set; } = "This item has already sold.";
        public override string ConsignNotEnough { get; set; } = "There is not enough of this item for sale.";
        public override string ConsignBuyOwnItem { get; set; } = "You cannot buy your own item.";
        public override string ConsignBuyGuildFundsGuild { get; set; } = "You cannot use Guild Funds to buy from a merchant because you are not in a guild.";
        public override string ConsignBuyGuildFundsPermission { get; set; } = "You cannot use Guild Funds to buy from the market place because you do not have permission.";
        public override string ConsignBuyGuildFundsCost { get; set; } = "Your Guild cannot afford to buy this many items.";
        public override string ConsignBuyGuildFundsUsed { get; set; } = "{0} used {1:#,##0} gold of guild funds to buy {2} x{3}.";
        public override string ConsignBuyCost { get; set; } = "你的金币不足.";


        public override string StoreNotAvailable { get; set; } = "无法购买, 商品已下线.";
        public override string StoreNeedSpace { get; set; } = "你不能携带更多东西, 包裹空间不足.";
        public override string StoreCost { get; set; } = "你的元宝不足.";


        public override string GuildNeedHorn { get; set; } = "你需要一个沃玛号角才能创建行会.";
        public override string GuildNeedGold { get; set; } = "你没有足够的金币创建行会.";
        public override string GuildBadName { get; set; } = "行会的名称不符合命名规则，无法创建.";
        public override string GuildNameTaken { get; set; } = "该行会名称已经被使用.";
        public override string GuildNoticePermission { get; set; } = "你没有权限更新行会公告.";
        public override string GuildEditMemberPermission { get; set; } = "你没有权限更改行会成员信息.";
        public override string GuildMemberLength { get; set; } = "公会头衔太长无法编辑.";
        public override string GuildMemberNotFound { get; set; } = "找不到行会成员.";
        public override string GuildKickPermission { get; set; } = "你没有权限踢出行会成员.";
        public override string GuildKickSelf { get; set; } = "你无法将自己踢出行会.";
        public override string GuildMemberKicked { get; set; } = "{0}被{1}踢出了行会.";
        public override string GuildKicked { get; set; } = "你被{0}踢出了行会.";
        public override string GuildManagePermission { get; set; } = "你没有管理行会的权限.";
        public override string GuildMemberLimit { get; set; } = "行会已经达到成员数上限.";
        public override string GuildMemberCost { get; set; } = "Guild does not have enough funds to increase member limit.";
        public override string GuildStorageLimit { get; set; } = "行会仓库已经达到空间上限.";
        public override string GuildStorageCost { get; set; } = "Guild does not have enough funds to increase storage limit.";
        public override string GuildInvitePermission { get; set; } = "You do not have permission to invite new members";
        public override string GuildInviteGuild { get; set; } = "Player: {0}, is already in another guild.";
        public override string GuildInviteInvited { get; set; } = "Player: {0}, is currently being invited to another Guild.";
        public override string GuildInviteNotAllowed { get; set; } = "玩家: {0} 目前不允许加入行会.";
        public override string GuildInvitedNotAllowed { get; set; } = "{0} wishes to invite you to the guild {1}, but you are not allowing Invites. @AllowGuild";
        public override string GuildInviteRoom { get; set; } = "Your guild already has reached it's member limit.";
        public override string GuildNoGuild { get; set; } = "你当前没有加入行会.";
        public override string GuildWarPermission { get; set; } = "你没有权限提交行会战.";
        public override string GuildNotFoundGuild { get; set; } = "无法找到行会{0}.";
        public override string GuildWarOwnGuild { get; set; } = "无法跟自己的行会进行行会战.";
        public override string GuildAlreadyWar { get; set; } = "当前正与{0}行会战.";
        public override string GuildWarCost { get; set; } = "金币不足无法进行行会战.";
        public override string GuildWarFunds { get; set; } = "{0}使用了{1:#,##0}行会资金提交了与{2}的行会战.";
        public override string GuildConquestCastle { get; set; } = "你已经是城主，不能提交攻城战.";
        public override string GuildConquestExists { get; set; } = "你已经提交了一个攻城战申请.";
        public override string GuildConquestBadCastle { get; set; } = "占领无效.";
        public override string GuildConquestProgress { get; set; } = "攻城战期间无法提交攻城战申请.";
        public override string GuildConquestNeedItem { get; set; } = "你需要{0}来提交{1}攻城战.";
        public override string GuildConquestSuccess { get; set; } = "一个行会已经提交了对你所占领城池的攻城战.";
        public override string GuildConquestDate { get; set; } = "你的行会提交了对{0}的攻城战.";
        public override string GuildJoinGuild { get; set; } = "你已经加入了行会.";
        public override string GuildJoinTime { get; set; } = "You cannot join a guild a for another {0}";
        public override string GuildJoinNoGuild { get; set; } = "Player: {0}, is no longer in a guild.";
        public override string GuildJoinPermission { get; set; } = "Player: {0}, does not have permission to add you to the guild.";
        public override string GuildJoinNoRoom { get; set; } = "{0}'s group has already reached the maximum size.";
        public override string GuildJoinWelcome { get; set; } = "欢迎加入行会: {0}.";
        public override string GuildMemberJoined { get; set; } = "{0} has invited {1} to the guild.";
        public override string GuildLeaveFailed { get; set; } = "Failed to leave guild, You cannot leave other guild members without a leader.";
        public override string GuildLeave { get; set; } = "你已经离开了行会.";
        public override string GuildMemberLeave { get; set; } = "{0}已经离开行会.";
        public override string GuildWarDeath { get; set; } = "来自{1}行会的{0}被{3}行会的{2}在行会战里击杀了.";


        public override string GroupNoGroup { get; set; } = "You are not in a group.";
        public override string GroupNotLeader { get; set; } = "You are not the leader of your group";
        public override string GroupMemberNotFound { get; set; } = "Could not find Group Membmer {0} in your group.";
        public override string GroupAlreadyGrouped { get; set; } = "Player: {0}, is already in another group.";
        public override string GroupAlreadyInvited { get; set; } = "Player: {0}, is currently being invited to another group.";
        public override string GroupInviteNotAllowed { get; set; } = "Player: {0}, is not allowing group invites.";
        public override string GroupSelf { get; set; } = "You can not group with yourself.";
        public override string GroupMemberLimit { get; set; } = "{0}'s group has already reached the maximum size.";
        public override string GroupRecallDelay { get; set; } = "You cannot group recall for another {0}";
        public override string GroupRecallMap { get; set; } = "You cannot group recall on this map";
        public override string GroupRecallNotAllowed { get; set; } = "You are not allowing group recall";
        public override string GroupRecallMemberNotAllowed { get; set; } = "{0} is now allowing group recall";
        public override string GroupRecallFromMap { get; set; } = "You cannot be recalled from this map.";
        public override string GroupRecallMemberFromMap { get; set; } = "{0} cannot be recalled from this map.";


        public override string TradeAlreadyTrading { get; set; } = "You are already Trading with Someone.";
        public override string TradeAlreadyHaveRequest { get; set; } = "You already have a request to trade with Someone.";
        public override string TradeNeedFace { get; set; } = "You need to be facing a player to request a Trade.";
        public override string TradeTargetNotAllowed { get; set; } = "{0} isn't allowing trade requests.";
        public override string TradeTargetAlreadyTrading { get; set; } = "{0} is already Trading.";
        public override string TradeTargetAlreadyHaveRequest { get; set; } = "{0} already has a trade reqeust.";
        public override string TradeNotAllowed { get; set; } = "{0} wishes to trade with you, but you are not allowing trades. @AllowTrade";
        public override string TradeTargetDead { get; set; } = "You cannot trade a dead person.";
        public override string TradeRequested { get; set; } = "You have send a trade request to {0}...";
        public override string TradeWaiting { get; set; } = "Waiting for Partner to Accept Trade...";
        public override string TradePartnerWaiting { get; set; } = "Your Partner is waiting for you to Accept Trade...";
        public override string TradeNoGold { get; set; } = "You do not have enough gold To Trade....";
        public override string TradePartnerNoGold { get; set; } = "Your partner dose not have enough gold To Trade.";
        public override string TradeTooMuchGold { get; set; } = "You cannot carry this much gold.";
        public override string TradePartnerTooMuchGold { get; set; } = "Your Partner cannot carry this much gold...";
        public override string TradeFailedItemsChanged { get; set; } = "Your Items were changed, Trade Failed.";
        public override string TradeFailedPartnerItemsChanged { get; set; } = "{0}'s Items were changed, Trade Failed.";
        public override string TradeNotEnoughSpace { get; set; } = "You can not Carry this many items, Please make space in your inventory and try again.";
        public override string TradeComplete { get; set; } = "Trade Complete..";


        public override string NPCFundsGuild { get; set; } = "You cannot use Guild Funds to buy from a merchant because you are not in a guild.";
        public override string NPCFundsPermission { get; set; } = "You cannot use Guild Funds to buy from a merchant because you do not have permission.";
        public override string NPCFundsCost { get; set; } = "无法买此物，你公会需要{0:#,##0}金币.";
        public override string NPCCost { get; set; } = "无法买此物，你公会需要{0:#,##0}金币.";
        public override string NPCNoRoom { get; set; } = "你无法带这么多东西.";
        public override string NPCFundsBuy { get; set; } = "{0} 已用 {1:#,##0} 公会金币去购买 {2} x{3}.";
        public override string NPCSellWorthless { get; set; } = "无法出售此物";
        public override string NPCSellTooMuchGold { get; set; } = "无法出售此物，你携带了太多金币";
        public override string NPCSellResult { get; set; } = "你卖出 {0} 个 物品， 收到 {1:#,##0} 金币..";
        public override string FragmentCost { get; set; } = "无法将这些物品转换为碎片，你需要 {0:#,##0} 金币.";
        public override string FragmentSpace { get; set; } = "无法将这些物品转换为碎片，你需要背包空间.";
        public override string FragmentResult { get; set; } = "你花费了{1:#,##0} 金币将 {0} 个物品变为碎片.";
        public override string AccessoryLevelCost { get; set; } = "金币不足，你无法支付升级首饰.";
        public override string AccessoryLeveled { get; set; } = "恭喜你的{0}已经升级，已经可以升级加属性.";
        public override string RepairFail { get; set; } = "你无法修理{0}.";
        public override string RepairFailRepaired { get; set; } = "你无法修理{0},已满持久.";
        public override string RepairFailLocation { get; set; } = "你无法在这里修理{0}.";
        public override string RepairFailCooldown { get; set; } = "你需要等待{1}的时间才能下一次特修{0}";
        public override string NPCRepairGuild { get; set; } = "You cannot use Guild Funds to repair because you are not in a guild.";
        public override string NPCRepairPermission { get; set; } = "You cannot use Guild Funds to repair because you do not have permission.";
        public override string NPCRepairGuildCost { get; set; } = "Unable to repair items, Your Guild needs another {0:#,##0} Gold.";
        public override string NPCRepairCost { get; set; } = "无法修理此物，你还需要{0:#,##0}金币.";
        public override string NPCRepairResult { get; set; } = "你修理了 {0} 花费了 {1:#,##0} 金币.";
        public override string NPCRepairSpecialResult { get; set; } = "你特殊修理了{0} ， 花费了 {1:#,##0} 金币.";
        public override string NPCRepairGuildResult { get; set; } = "{0} used {1:#,##0} gold of guild funds to repair {2} item(s).";
        public override string NPCRefinementGold { get; set; } = "没有足够的金币.";
        public override string NPCRefinementStoneFailedRoom { get; set; } = "精炼石合成失败，无法获得该物品";
        public override string NPCRefinementStoneFailed { get; set; } = "精炼合成失败.";
        public override string NPCRefineNotReady { get; set; } = "无法取出武器，还没准备好.";
        public override string NPCRefineNoRoom { get; set; } = "无法取出武器，包裹需要空间";
        public override string NPCRefineSuccess { get; set; } = "恭喜，精炼成功";
        public override string NPCRefineFailed { get; set; } = "见鬼了，精炼失败";
        public override string NPCMasterRefineGold { get; set; } = "不好意思你的金币不足,无法完成大师级炼制的成功率评估，需要花费: {0:#,##0}.";
        public override string NPCMasterRefineChance { get; set; } = "精炼成功率: {0}%";
        public override string AccessoryRefineSuccess { get; set; } = "感谢你 {0} 成功精炼 {1} + {2}.";
        public override string AccessoryRefineFailed { get; set; } = "精炼失败，你的 {0} 已损坏";


        public override string ChargeExpire { get; set; } = "能量 {0} 已经消失.";
        public override string ChargeFail { get; set; } = "无法集中能量 {0}.";
        public override string CloakCombat { get; set; } = "你无法在战斗中潜行";
        public override string DashFailed { get; set; } = "没有足够的力量，对方级别过高.";
        public override string WraithLevel { get; set; } = "{0}的等级比你高 你无法亡灵束缚.";
        public override string AbyssLevel { get; set; } = "{0} 等级比你高 你无法深渊.";
        public override string SkillEffort { get; set; } = "在这个地图使用 {0} 需要花费更多的能量， 你在{1}时间内无法使用物品.";
        public override string SkillBadMap { get; set; } = "你无法在此地图上使用 {0}.";


        public override string HorseDead { get; set; } = "阵亡状态无法骑马.";
        public override string HorseOwner { get; set; } = "你还没有马.";
        public override string HorseMap { get; set; } = "这个地图无法骑马.";
    }
}
