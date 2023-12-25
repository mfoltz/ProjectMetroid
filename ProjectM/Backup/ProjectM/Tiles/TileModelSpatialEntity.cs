// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelSpatialEntity
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModelSpatialEntity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelSpatialEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public BoundsMinMax EntityBounds;
    [FieldOffset(24)]
    public ProjectM.TileType TileTypes;
    [FieldOffset(28)]
    public TilePosition TilePosition;
    [FieldOffset(40)]
    public BlobAssetReference<TileBlob> TileData;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087575, XrefRangeEnd = 1087578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087579, RefRangeEnd = 1087580, XrefRangeStart = 1087578, XrefRangeEnd = 1087579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TileModelSpatialEntity other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelSpatialEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialEntity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileModelSpatialEntity()
    {
      Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileModelSpatialEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr);
      TileModelSpatialEntity.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, nameof (Entity));
      TileModelSpatialEntity.NativeFieldInfoPtr_EntityBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, nameof (EntityBounds));
      TileModelSpatialEntity.NativeFieldInfoPtr_TileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, nameof (TileTypes));
      TileModelSpatialEntity.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, nameof (TilePosition));
      TileModelSpatialEntity.NativeFieldInfoPtr_TileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, nameof (TileData));
      TileModelSpatialEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, 100685617);
      TileModelSpatialEntity.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelSpatialEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, 100685618);
      TileModelSpatialEntity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, 100685619);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelSpatialEntity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
