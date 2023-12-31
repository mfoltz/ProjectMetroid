// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.ITileBrushComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.Tiles
{
  public class ITileBrushComponent : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_BrushType_Public_Abstract_Virtual_New_get_TileBrushType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_ITileData_0;

    public virtual unsafe TileBrushType BrushType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ITileBrushComponent.NativeMethodInfoPtr_get_BrushType_Public_Abstract_Virtual_New_get_TileBrushType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileBrushType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe ITileData GetData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ITileBrushComponent.NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_ITileData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ITileData) null : new ITileData(pointer);
    }

    static ITileBrushComponent()
    {
      Il2CppClassPointerStore<ITileBrushComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (ITileBrushComponent));
      ITileBrushComponent.NativeMethodInfoPtr_get_BrushType_Public_Abstract_Virtual_New_get_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITileBrushComponent>.NativeClassPtr, 100669879);
      ITileBrushComponent.NativeMethodInfoPtr_GetData_Public_Abstract_Virtual_New_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITileBrushComponent>.NativeClassPtr, 100669880);
    }

    public ITileBrushComponent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
