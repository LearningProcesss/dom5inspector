# Setup container

sudo apt-get -y update
sudo apt-get -y upgrade
sudo apt-get install -y sqlite3 libsqlite3-dev
.tablòe
dotnet tool install --global dotnet-aspnet-codegenerator

cat << \EOF >> ~/.bash_profile
# Add .NET Core SDK tools
export PATH="$PATH:/home/vscode/.dotnet/tools"
EOF

source ~/.bash_profile

dotnet tool install --global dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

# SQLite3

sqlite3

.mode csv

.separator "\t"

.import /workspaces/dom5inspector/Dom5Comparator/gamedata/BaseU.csv BaseU

.clone dom5.db

dotnet ef dbcontext scaffold "Data Source=dom5.db;" Microsoft.EntityFrameworkCore.SQLite -o Model

