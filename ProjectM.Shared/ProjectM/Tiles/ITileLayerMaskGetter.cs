// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.ITileLayerMaskGetter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  public class ITileLayerMaskGetter : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0;

    [CallerCount(0)]
    public virtual unsafe BitMask2D_16x16 Get([In] ref TileLayer tileLayer, [In] ref TileCell tileCell)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref tileLayer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref tileCell;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ITileLayerMaskGetter.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ITileLayerMaskGetter()
    {
      Il2CppClassPointerStore<ITileLayerMaskGetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (ITileLayerMaskGetter));
      ITileLayerMaskGetter.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_BitMask2D_16x16_byref_TileLayer_byref_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITileLayerMaskGetter>.NativeClassPtr, 100669834);
    }

    public ITileLayerMaskGetter(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
