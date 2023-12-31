// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.CollisionMaskGetter_MultiFlags_OR
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
  public struct CollisionMaskGetter_MultiFlags_OR
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Flags;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Tiles_ITileLayerMaskGetter_Get_Private_Virtual_Final_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0;
    [FieldOffset(0)]
    public MapCollisionFlags Flags;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793090, RefRangeEnd = 793091, XrefRangeStart = 793089, XrefRangeEnd = 793090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 Get([In] ref TileLayer tileLayer, [In] ref TileCell tileCell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionMaskGetter_MultiFlags_OR.NativeMethodInfoPtr_Get_Public_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793090, RefRangeEnd = 793091, XrefRangeStart = 793090, XrefRangeEnd = 793091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BitMask2D_16x16 ProjectM_Tiles_ITileLayerMaskGetter_Get(
      [In] ref TileLayer tileLayer,
      [In] ref TileCell tileCell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tileLayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CollisionMaskGetter_MultiFlags_OR.NativeMethodInfoPtr_ProjectM_Tiles_ITileLayerMaskGetter_Get_Private_Virtual_Final_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CollisionMaskGetter_MultiFlags_OR()
    {
      Il2CppClassPointerStore<CollisionMaskGetter_MultiFlags_OR>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (CollisionMaskGetter_MultiFlags_OR));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionMaskGetter_MultiFlags_OR>.NativeClassPtr);
      CollisionMaskGetter_MultiFlags_OR.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionMaskGetter_MultiFlags_OR>.NativeClassPtr, nameof (Flags));
      CollisionMaskGetter_MultiFlags_OR.NativeMethodInfoPtr_Get_Public_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionMaskGetter_MultiFlags_OR>.NativeClassPtr, 100669839);
      CollisionMaskGetter_MultiFlags_OR.NativeMethodInfoPtr_ProjectM_Tiles_ITileLayerMaskGetter_Get_Private_Virtual_Final_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionMaskGetter_MultiFlags_OR>.NativeClassPtr, 100669840);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollisionMaskGetter_MultiFlags_OR>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
