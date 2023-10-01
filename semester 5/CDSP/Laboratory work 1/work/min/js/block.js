function blockSublist(element)
{
	if(element.style.display == "")
	{
		element.style.display = "none";
	}
	else
	{
		element.style.display = "";
	}
}
function blockText (element, list)
{
	if(element.style.display == "")
	{
		element = list[0];
	}
	
	for(let i = 0; i < list.length; i++)
	{
		list[i].style.display = "none";
	}
	element.style.display = "";
}



var listProgramming = []

function onloadBlock()
{
	listProgramming = [
		LangNone,
		LangC,
		LangJava,
		LangCS,
		LangPascal,
		LangHTML,
		LangCSS,
		LangJS,
		LangPHP,
		LangMySQL,
		LangWeb,
		LangBasic,
		LangAssembler,
		LangPython
	];
}

