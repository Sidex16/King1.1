

//vector<string> PlayersName;
//vector<string> Tasks;
//vector<string> Judgements;
//vector<int> King;
//int NumberOfPlayers;

//void FillPlayers()
//{
//    cout << "Enter number of players:" << endl;
//    cin >> NumberOfPlayers;

//    for (int i = 0; i < NumberOfPlayers; i++)
//    {
//        string name;
//        cout << "Enter player " << i + 1 << " name:" << endl;
//        cin >> name;
//        PlayersName.push_back(name);

//    }
//}

//void WhoIsKing()
//{
//    bool tyt;
//    int r;
//    for (int i = 0; i < PlayersName.size();)
//    {
//        tyt = false;
//        r = rand() % PlayersName.size();
//        for (int j = 0; j < i; j++)
//        {
//            if (King[j] == r)
//            {
//                tyt = true;
//                break;
//            }

//        }
//        if (!tyt)
//        {
//            King.push_back(r);
//            i++;
//        }
//    }
//}

//void ShowAllPlayers()
//{
//    for (int i = 0; i < PlayersName.size(); i++)
//    {
//        if (King[i] == 0)
//        {
//            system("cls");
//            cout << PlayersName[i] << " - King" << endl;
//        }
//    }
//    _getch();
//    for (int i = 0; i < PlayersName.size(); i++)
//    {
//        cout << i + 1 << ". " << PlayersName[i] << "  \t" << King[i] << endl;
//    }
//    King.clear();
//}

//void Settings()
//{
//    vector<string>::iterator it = PlayersName.begin();
//    int value, number;
//    string newName;
//    cout << "Choose operation :" << endl << "1. Delete player" << endl << "2. Add player" << endl;
//    cin >> value;
//    switch (value)
//    {
//        case 1:
//            cout << "Enter the number of player:" << endl;
//            cin >> number;
//            PlayersName.erase(it + (number - 1));
//            break;
//        case 2:
//            cout << "Enter new player:" << endl;
//            cin >> newName;
//            PlayersName.push_back(newName);

//        default:
//            break;
//    }
//}

//void FillTask()
//{
//    string task;
//    iTasks.open("Task.txt");
//    while (!iTasks.eof())
//    {
//        getline(iTasks, task);
//        Tasks.push_back(task);
//    }
//    iTasks.close();
//}

//void RandomTask()
//{
//    cout << Tasks[rand() % Tasks.size()] << endl;
//}

//void FillJudgement()
//{
//    string judgement;
//    iJudgements.open("Judgement.txt");
//    while (!iJudgements.eof())
//    {
//        getline(iJudgements, judgement);
//        Judgements.push_back(judgement);
//    } 
//    iJudgements.close();
//}

//void RandomJudgement()
//{
//    cout << Judgements[rand() % Judgements.size()] << endl;
//}

//void GoToSettings()
//{
//    switch (_getch())
//    {
//        case 's':
//            Settings();
//            break;
//        case 'r':
//            RandomTask();
//            _getch();
//            break;
//        case 'x':
//            RandomJudgement();
//            _getch();
//            break;

//        default:
//            break;
//    }

//}

//int main()
//{
//    srand(time(0));

//    SetConsoleOutputCP(65001);

//    FillJudgement();
//    FillTask();
//    FillPlayers();
//    while (true)
//    {
//        WhoIsKing();
//        ShowAllPlayers();
//        GoToSettings();
//    }

//    return 0;
//}