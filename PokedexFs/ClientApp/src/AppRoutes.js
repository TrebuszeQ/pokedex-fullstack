import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home2 } from "./components/home/Home2";
import {Layout} from "./components/Layout";

const AppRoutes = [
  {
    index: true,
    element: <Home2 />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  },
  {
    path: '/home2',
    element: <Layout/>
  },
];

export default AppRoutes;
