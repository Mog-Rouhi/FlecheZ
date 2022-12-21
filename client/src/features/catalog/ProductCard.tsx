import {
  Avatar,
  Button,
  Card,
  CardActions,
  CardContent,
  CardHeader,
  CardMedia,
  Typography,
} from "@mui/material";
import { memo } from "react";
import { Link } from "react-router-dom";
import { Product } from "../../app/models/product";

interface Props {
  product: Product;
}

export default memo (function ProductCard({ product }: Props) {
  return (
    <Card sx={{ backgroundColor: 'rgba(245, 245, 245, 0)', boxShadow: 'none', border: '1px solid #e6e6e6'
    }}>
      <CardHeader
        avatar={
          <Avatar sx={{ bgcolor: "primary.dark" }}>
            {product.name.charAt(0).toUpperCase()}
          </Avatar>
        }
        title={product.name}
        titleTypographyProps={{
          sx: { fontWeight: "bold", color: "primary.dark" },
        }}
      />
      <CardMedia
        sx={{
          height: 210,
          backgroundSize: "contain",
          bgcolor: "",
        }}
        image={product.pictureUrl}
        title={product.name}
      />
      <CardContent>
        <Typography gutterBottom color="secondary" variant="h5" fontSize='15px'>
          €{(product.price / 100).toFixed(2)}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {product.brand} / {product.type}
        </Typography>
      </CardContent>
      <CardActions>
        <Button size="small">Add to cart</Button>
        <Button component={Link} to={`/catalog/${product.id}`} size="small">View</Button>
      </CardActions>
    </Card>
  );
})
