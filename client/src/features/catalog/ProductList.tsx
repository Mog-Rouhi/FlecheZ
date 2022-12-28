import { Grid } from "@mui/material";
import { memo } from "react";
import { Product } from "../../app/models/product";
import ProductCard from "./ProductCard";

interface Props {
  products: Product[];
}
export default memo(function ProductList({ products }: Props) {
  return (
    <Grid container spacing={4}>
      {products.map((item) => (
        <Grid item xs={4} key={item.id}>
          <ProductCard product={item} />
        </Grid>
      ))}
    </Grid>
  );
});
