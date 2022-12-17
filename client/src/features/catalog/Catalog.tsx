import { Product } from "../../app/models/product";

interface Props {
  products: Product[];
  addProduct: () => void;
}

export default function Catalog({products, addProduct}: Props) {
  return (
    <>
      <ul>
        {products.map((item, index) => (
          <li key={index}>{item.name}</li>
        ))}
      </ul>
      <button onClick={addProduct}>Add Product</button>
    </>
  );
}
