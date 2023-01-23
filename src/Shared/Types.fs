namespace Shared.Types

type Counter = int

type Model =
    {
      counter: Counter option
      videoId: string option
    }
    static member Empty =
        { 
          counter = None
          videoId = None
        }

type ProcessModel =
  {
    proc_id:string
    label:string
    mh:float
    link:NodeModel option
  }
and IngredientModel = 
  {
    port_id:string
    label:string
    link:NodeModel option
  }
and ComponentModel =
  {
    port_id:string
    label:string
    link:ref<NodeModel> option
  }
and NodeModel =
  {
    node_id:string
    label:string
    compo:ComponentModel option
    ingre:IngredientModel list
    proc:ProcessModel
  }

type ProductModel = 
  {
    id:string
    name: string
    node:NodeModel
  }
  