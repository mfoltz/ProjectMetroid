// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelSpatialCell
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModelSpatialCell
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Union;
    private static readonly System.IntPtr NativeFieldInfoPtr_PosX;
    private static readonly System.IntPtr NativeFieldInfoPtr_PosY;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelSpatialCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public int Union;
    [FieldOffset(0)]
    public short PosX;
    [FieldOffset(2)]
    public short PosY;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087572, XrefRangeEnd = 1087575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialCell.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 411711, RefRangeEnd = 411739, XrefRangeStart = 411711, XrefRangeEnd = 411739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TileModelSpatialCell other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialCell.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelSpatialCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialCell.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileModelSpatialCell()
    {
      Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileModelSpatialCell));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr);
      TileModelSpatialCell.NativeFieldInfoPtr_Union = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr, nameof (Union));
      TileModelSpatialCell.NativeFieldInfoPtr_PosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr, nameof (PosX));
      TileModelSpatialCell.NativeFieldInfoPtr_PosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr, nameof (PosY));
      TileModelSpatialCell.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr, 100685614);
      TileModelSpatialCell.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelSpatialCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr, 100685615);
      TileModelSpatialCell.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr, 100685616);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelSpatialCell>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
