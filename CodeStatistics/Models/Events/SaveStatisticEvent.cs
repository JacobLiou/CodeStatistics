﻿using Prism.Events;
using System.Collections.Generic;

namespace CodeStatistics.Models.Events;

public class SaveStatisticEvent : PubSubEvent
{ }

public class SaveStatisticReadyEvent : PubSubEvent
{ }

public class SettingSetSaveEvent
    : PubSubEvent<(
        IEnumerable<CodeDirectory>,
        IEnumerable<FileType>,
        IEnumerable<SearchKeyword>
    )>
{ }

public class FileStatisticSaveEvent : PubSubEvent<IEnumerable<FileStatistic>>
{ }

public class AmountStatisticsSaveEvent : PubSubEvent<AmountStatistics>
{ }