export interface Photo {
    id: number;
    postDate: Date;
    url: string;
    description: string;
    allowCOmments: boolean;
    likes: number;
    comments: number;
    userId: number;
}