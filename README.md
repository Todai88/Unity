<h1><b>Unity</b></h1>

This will serve as a repository for me to track my progress throughout my Unity development.
I'm also hoping to add some nice resources later on.

<ol>

<h2><li><b>Number Wizard (console game):</b></li></h2>

<ul>

<h3><li> Problem:</li></h3>
	Deliver a simple number guessing game where the user thinks of a number and the 
	computer attemps to find the number by asking the user if the number is higher
	or lower than a guess. 
<h3><li> Learning outcomes: </li></h3>
	Quite a basic assignment really. 
	<Enter>
	I've got experience using C# and .NET.
	The only real problem I faced was working with Unity's
	<code>GetKeyDown</code>-events. 
	<Enter>
	Mainly I had a problem restaring the game loop, since
	both confirming that a number was correct and 
	confirming that you wish to play again use
	<code>KeyCode.Return</code>.
	So what I sorted that out by adding a 
	boolean (`flag`) to handle the state
	as well as 'flushing' the current <code>Input</code>-buffer
	by using <code>Input.ResetInputAxes()</code>.
</ul>

</ol>
