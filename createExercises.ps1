$sln = Read-Host -Prompt 'Input the solution/folder name'
$exercises = Read-Host -Prompt 'Input the amount of exercises'
$gitignore = Get-Item -Path ".gitignore"

# Create subfolder
$command = "New-Item -Path . -Name '$sln' -ItemType 'directory'"  
Invoke-Expression $command
$command = "cd $sln"  
Invoke-Expression $command

Copy-Item $gitignore

for ($num = 1 ; $num -le $exercises ; $num++)
{	
	$name = $num;
	if ($num.tostring().length -eq 1){
		$name = "0" + $num
	} 
	
	# Create subfolder
	$command = "New-Item -Path . -Name 'oefening-$name' -ItemType 'directory'"  
	Invoke-Expression $command
	$command = "cd oefening-$name"
	Invoke-Expression $command
	Copy-Item $gitignore
	$command = "dotnet new sln -n oefening-$name"
    Invoke-Expression $command	
	$command = "dotnet new xunit --framework 'netcoreapp3.1' -o oefening-$name-test"
    Invoke-Expression $command
	$command = "dotnet new wpf --framework 'netcoreapp3.1' -o oefening-$name-wpf"
    Invoke-Expression $command
	$command = "dotnet sln add oefening-$name-test oefening-$name-wpf"
    Invoke-Expression $command
	$command = "dotnet add oefening-$name-test reference oefening-$name-wpf"
    Invoke-Expression $command
	
	$dirs = Get-ChildItem -Path ""
	foreach ($dir in $dirs){
		$condition = (Get-Item $dir.FullName) -is [System.IO.DirectoryInfo]
		if ($condition) {
			Copy-Item $gitignore $dir.FullName
		}
	}
	
	$command = "cd oefening-$name-test"
	Invoke-Expression $command
	$command = "dotnet add package FlaUI.UIA3"
	Invoke-Expression $command
	$command = "cd .."
	Invoke-Expression $command
	$command = "cd .."
	Invoke-Expression $command
}