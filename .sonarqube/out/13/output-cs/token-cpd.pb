?
[/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Controllers/CustomerController.cs
	namespace 	
PizzaBox
 
. 
Client 
. 
Controllers %
{ 
[ 
Route 
( 	
$str	 
) 
] 
public 
class	 
CustomerController !
:" #

Controller$ .
{ 
[		 
HttpGet		 
]		 
[

 
HttpPost

 
]

 
[ $
ValidateAntiForgeryToken 
] 
public 

string 
Customer 
( 
CustomerViewModel ,
customer- 5
)5 6
{ 
if 
(	 


ModelState
 
. 
IsValid 
) 
{ 
return 
customer 
. 
SelectedName $
;$ %
} 
return 
$str 
; 
} 
} 
} ?

W/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Controllers/HomeController.cs
	namespace 	
PizzaBox
 
. 
Client 
. 
Controllers %
{ 
[ 
Route 
( 	
$str	 
) 
] 
public		 
class			 
HomeController		 
:		 

Controller		  *
{

 
private 
readonly 

UnitOfWork 
_unitOfWork  +
;+ ,
public 

HomeController 
( 

UnitOfWork $

unitOfWork% /
)/ 0
{ 
_unitOfWork 
= 

unitOfWork 
; 
} 
[ 
HttpGet 
] 
public 

IActionResult 
Index 
( 
)  
{ 
var 	
order
 
= 
new 
OrderViewModel $
($ %
)% &
;& '
order 
. 
	Construct 
( 
_unitOfWork !
)! "
;" #
return 
View 
( 
$str 
, 
order  
)  !
;! "
} 
} 
} ?!
X/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Controllers/OrderController.cs
	namespace 	
PizzaBox
 
. 
Client 
. 
Controllers %
{		 
[

 
Route

 
(

 	
$str

	 
)

 
]

 
public 
class	 
OrderController 
:  

Controller! +
{ 
private 
readonly 

UnitOfWork 
_unitOfWork  +
;+ ,
public 

OrderController 
( 

UnitOfWork %

unitOfWork& 0
)0 1
{ 
_unitOfWork 
= 

unitOfWork 
; 
} 
[ 
HttpGet 
] 
[ 
HttpPost 
] 
[ $
ValidateAntiForgeryToken 
] 
public 

IActionResult 
Order 
( 
OrderViewModel -
order. 3
)3 4
{ 
if 
(	 


ModelState
 
. 
IsValid 
) 
{ 
var 
crust 
= 
_unitOfWork 
.  
Crusts  &
.& '
Create' -
(- .
c. /
=>0 2
c3 4
.4 5
Name5 9
==: <
order= B
.B C
SelectedCrustC P
)P Q
.Q R
FirstR W
(W X
)X Y
;Y Z
var 
size 
= 
_unitOfWork 
. 
Sizes $
.$ %
Create% +
(+ ,
s, -
=>. 0
s1 2
.2 3
Name3 7
==8 :
order; @
.@ A
SelectedSizeA M
)M N
.N O
FirstO T
(T U
)U V
;V W
var 
toppings 
= 
new 
List 
<  
Topping  '
>' (
(( )
)) *
;* +
foreach 
( 
var 
item 
in 
order "
." #
SelectedToppings# 3
)3 4
{   	
toppings!!
 
.!! 
Add!! 
(!! 
_unitOfWork!! "
.!!" #
Toppings!!# +
.!!+ ,
Create!!, 2
(!!2 3
t!!3 4
=>!!5 7
t!!8 9
.!!9 :
Name!!: >
==!!? A
item!!B F
)!!F G
.!!G H
First!!H M
(!!M N
)!!N O
)!!O P
;!!P Q
}"" 	
var$$ 
newPizza$$ 
=$$ 
new$$ 
Pizza$$  
{$$! "
Crust$$# (
=$$) *
crust$$+ 0
,$$0 1
Size$$2 6
=$$7 8
size$$9 =
,$$= >
Toppings$$? G
=$$H I
toppings$$J R
}$$S T
;$$T U
var%% 
newOrder%% 
=%% 
new%% 
Order%%  
{%%! "
Pizzas%%# )
=%%* +
new%%, /
List%%0 4
<%%4 5
Pizza%%5 :
>%%: ;
{%%< =
newPizza%%> F
}%%G H
}%%I J
;%%J K
_unitOfWork'' 
.'' 
Orders'' 
.'' 
Read'' 
(''  
newOrder''  (
)''( )
;'') *
_unitOfWork(( 
.(( 
Save(( 
((( 
)(( 
;(( 
ViewBag** 
.** 
Order** 
=** 
newOrder**  
;**  !
return,, 
View,, 
(,, 
$str,, 
),, 
;,,  
}-- 
order// 
.// 
	Construct// 
(// 
_unitOfWork// !
)//! "
;//" #
return11 
View11 
(11 
$str11 
,11 
order11  
)11  !
;11! "
}22 
}33 
}44 ?
U/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Models/CustomerViewModel.cs
	namespace 	
PizzaBox
 
. 
Client 
. 
Models  
{ 
public		 
class			 
CustomerViewModel		  
{

 
public 

List 
< 
Customer 
> 
	Customers #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 
Required 
( 
ErrorMessage 
= 
$str 5
)5 6
]6 7
[ 
DataType 
( 
DataType 
. 
Text 
) 
] 
public 

string 
SelectedName 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 
Required 
( 
ErrorMessage 
= 
$str 3
)3 4
]4 5
[ 
DataType 
( 
DataType 
. 
Text 
) 
] 
public 

string 
SelectedAddress !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 
Required 
( 
ErrorMessage 
= 
$str 8
)8 9
]9 :
[ 
DataType 
( 
DataType 
. 
Text 
) 
] 
public 

long 
SelectedNumber 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

void 
	Construct 
( 

UnitOfWork $

unitOfWork% /
)/ 0
{ 
	Customers 
= 

unitOfWork 
. 
	Customers &
.& '
Create' -
(- .
c. /
=>0 2
!3 4
string4 :
.: ;
IsNullOrWhiteSpace; M
(M N
cN O
.O P
NameP T
)T U
)U V
.V W
ToListW ]
(] ^
)^ _
;_ `
} 
}%% 
}&& ?
R/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Models/ErrorViewModel.cs
	namespace 	
PizzaBox
 
. 
Client 
. 
Models  
{ 
public 
class	 
ErrorViewModel 
{ 
public 

string 
	RequestId 
{ 
get !
;! "
set# &
;& '
}( )
public		 

bool		 
ShowRequestId		 
=>		  
!		! "
string		" (
.		( )
IsNullOrEmpty		) 6
(		6 7
	RequestId		7 @
)		@ A
;		A B
}

 
} ?"
R/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Models/OrderViewModel.cs
	namespace 	
PizzaBox
 
. 
Client 
. 
Models  
{		 
public

 
class

	 
OrderViewModel

 
:

 
IValidatableObject

  2
{ 
public 

List 
< 
Crust 
> 
Crusts 
{ 
get  #
;# $
set% (
;( )
}* +
public 

List 
< 
Size 
> 
Sizes 
{ 
get !
;! "
set# &
;& '
}( )
public 

List 
< 
Topping 
> 
Toppings !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 
Required 
( 
ErrorMessage 
= 
$str +
)+ ,
], -
[ 
DataType 
( 
DataType 
. 
Text 
) 
] 
public 

string 
SelectedCrust 
{  !
get" %
;% &
set' *
;* +
}, -
[ 
Required 
( 
ErrorMessage 
= 
$str *
)* +
]+ ,
[ 
DataType 
( 
DataType 
. 
Text 
) 
] 
public 

string 
SelectedSize 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 
Required 
( 
ErrorMessage 
= 
$str .
). /
]/ 0
public 

List 
< 
string 
> 
SelectedToppings (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 

void 
	Construct 
( 

UnitOfWork $

unitOfWork% /
)/ 0
{ 
Crusts 
= 

unitOfWork 
. 
Crusts  
.  !
Create! '
(' (
c( )
=>* ,
!- .
string. 4
.4 5
IsNullOrWhiteSpace5 G
(G H
cH I
.I J
NameJ N
)N O
)O P
.P Q
ToListQ W
(W X
)X Y
;Y Z
Sizes 
= 

unitOfWork 
. 
Sizes 
. 
Create %
(% &
s& '
=>( *
!+ ,
string, 2
.2 3
IsNullOrWhiteSpace3 E
(E F
sF G
.G H
NameH L
)L M
)M N
.N O
ToListO U
(U V
)V W
;W X
Toppings   
=   

unitOfWork   
.   
Toppings   $
.  $ %
Create  % +
(  + ,
t  , -
=>  . 0
!  1 2
string  2 8
.  8 9
IsNullOrWhiteSpace  9 K
(  K L
t  L M
.  M N
Name  N R
)  R S
)  S T
.  T U
ToList  U [
(  [ \
)  \ ]
;  ] ^
}!! 
public## 

IEnumerable## 
<## 
ValidationResult## '
>##' (
Validate##) 1
(##1 2
ValidationContext##2 C
validationContext##D U
)##U V
{$$ 
if%% 
(%%	 

SelectedToppings%%
 
.%% 
Count%%  
<%%! "
$num%%# $
||%%% '
SelectedToppings%%( 8
.%%8 9
Count%%9 >
>%%? @
$num%%A B
)%%B C
{&& 
yield'' 
return'' 
new'' 
ValidationResult'' )
('') *
$str''* a
,''a b
new''c f
[''f g
]''g h
{''i j
$str''k }
}''~ 
)	'' ?
;
''? ?
}(( 
})) 
}** 
}++ ?

D/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Program.cs
	namespace

 	
	_PizzaBox


 
.

 
Client

 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} ?
D/home/drayh/revature/project_pizzabox_web/PizzaBox.Client/Startup.cs
	namespace 	
	_PizzaBox
 
. 
Client 
{ 
public 
class	 
Startup 
{ 
public 

Startup 
( 
IConfiguration !
configuration" /
)/ 0
{ 
Configuration 
= 
configuration #
;# $
} 
public 

IConfiguration 
Configuration '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

void 
ConfigureServices !
(! "
IServiceCollection" 4
services5 =
)= >
{ 
services 
. #
AddControllersWithViews &
(& '
)' (
;( )
services 
. 
	AddScoped 
< 

UnitOfWork #
># $
($ %
)% &
;& '
services 
. 
AddDbContext 
< 
PizzaBoxContext +
>+ ,
(, -
options- 4
=>5 7
{ 
options   
.   
	UseNpgsql   
(   
Configuration   '
.  ' (
GetConnectionString  ( ;
(  ; <
$str  < C
)  C D
,  D E
opts  F J
=>  K M
{!! 	
opts""
 
.""  
EnableRetryOnFailure"" #
(""# $
$num""$ %
)""% &
;""& '
}## 	
)##	 

;##
 
}$$ 
)$$ 
;$$ 	
}%% 
public(( 

void(( 
	Configure(( 
((( 
IApplicationBuilder(( -
app((. 1
,((1 2
IWebHostEnvironment((3 F
env((G J
,((J K
PizzaBoxContext((L [
context((\ c
)((c d
{)) 
if** 
(**	 

env**
 
.** 
IsDevelopment** 
(** 
)** 
)** 
{++ 
app,, 
.,, %
UseDeveloperExceptionPage,, %
(,,% &
),,& '
;,,' (
}-- 
else.. 

{// 
app00 
.00 
UseExceptionHandler00 
(00  
$str00  -
)00- .
;00. /
app22 
.22 
UseHsts22 
(22 
)22 
;22 
}33 
app44 	
.44	 

UseHttpsRedirection44
 
(44 
)44 
;44  
app55 	
.55	 

UseStaticFiles55
 
(55 
)55 
;55 
app77 	
.77	 


UseRouting77
 
(77 
)77 
;77 
app99 	
.99	 

UseAuthorization99
 
(99 
)99 
;99 
app;; 	
.;;	 

UseEndpoints;;
 
(;; 
	endpoints;;  
=>;;! #
{<< 
	endpoints== 
.== 
MapControllers==  
(==  !
)==! "
;==" #
}>> 
)>> 
;>> 	
}?? 
}@@ 
}AA 