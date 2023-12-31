// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.CollisionMaskGetter_SingleFlag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CollisionMaskGetter_SingleFlag
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Flag;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Tiles_ITileLayerMaskGetter_Get_Private_Virtual_Final_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0;
    [FieldOffset(0)]
    public MapCollisionFlags Flag;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793088, XrefRangeEnd = 793089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 Get([In] ref TileLayer tileLayer, [In] ref TileCell tileCell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionMaskGetter_SingleFlag.NativeMethodInfoPtr_Get_Public_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BitMask2D_16x16 ProjectM_Tiles_ITileLayerMaskGetter_Get(
      [In] ref TileLayer tileLayer,
      [In] ref TileCell tileCell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionMaskGetter_SingleFlag.NativeMethodInfoPtr_ProjectM_Tiles_ITileLayerMaskGetter_Get_Private_Virtual_Final_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CollisionMaskGetter_SingleFlag()
    {
      Il2CppClassPointerStore<CollisionMaskGetter_SingleFlag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (CollisionMaskGetter_SingleFlag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionMaskGetter_SingleFlag>.NativeClassPtr);
      CollisionMaskGetter_SingleFlag.NativeFieldInfoPtr_Flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionMaskGetter_SingleFlag>.NativeClassPtr, nameof (Flag));
      CollisionMaskGetter_SingleFlag.NativeMethodInfoPtr_Get_Public_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionMaskGetter_SingleFlag>.NativeClassPtr, 100669837);
      CollisionMaskGetter_SingleFlag.NativeMethodInfoPtr_ProjectM_Tiles_ITileLayerMaskGetter_Get_Private_Virtual_Final_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionMaskGetter_SingleFlag>.NativeClassPtr, 100669838);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollisionMaskGetter_SingleFlag>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
