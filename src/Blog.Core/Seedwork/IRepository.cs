using System.Linq.Expressions;

namespace Blog.Core.Seedwork
{
    public interface IRepository<T, Key> where T : class
    {
        Task<T> GetByIdAsync(Key id);

        // Lấy tất cả thực thể (Bất đồng bộ)
        Task<IEnumerable<T>> GetAllAsync();

        // Tìm kiếm thực thể dựa trên một biểu thức điều kiện (Lambda)
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        // Thêm một thực thể mới
        void Add(T entity);

        // Thêm một danh sách thực thể
        void AddRange(IEnumerable<T> entities);

        // Xóa một thực thể
        void Remove(T entity);

        // Xóa một danh sách thực thể
        void RemoveRange(IEnumerable<T> entities);
    }
}
