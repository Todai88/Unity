<h1><b>Solutions</b></h1> 
<ol>

<h2><li><b>Number Wizard (console game):</b></li></h2>

<ul> 

<h3><li> Solution-logic: </li></h3>
	I solved this by implementing basic refractoring instead of rewriting
	already implemented code. <br/>
	The core code is quite basic; it uses <code>Update()</code> to 
	capture<code>KeyDown-events</code> (up/down-arrow and return).<br/>
	If return is pushed the user is prompted to play again,
	if the user pushes return again the game resets by calling
	<code>StartingGame</code> which resets all the global variables.<br/>
	If up/down-arrow is pushed, the variables are manipulated
	and a basic calculation takes place: <code>(min + max) / 2 </code>.
	This continues to happen until the program has guessed the correct number.
<h3><li> Learning outcomes: </li></h3>
	Quite a basic assignment, really. 
	<br/><br/>
	I've got experience using C# and .NET.
	The only real problem I faced was working with Unity's
	<code>GetKeyDown-events</code>.
	<br/>
	Mainly I had a problem restaring the game loop, since
	both confirming that a number was correct and 
	confirming that you wish to play again use
	<code>KeyCode.Return</code>.
	So what I sorted that out by adding a 
	<code>boolean</code> (named 'flag') to handle the state
	as well as 'flushing' the current <code>Input-buffer</code>
	by using <code>Input.ResetInputAxes()</code>.
</ul>

</ol>
