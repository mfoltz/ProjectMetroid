// Decompiled with JetBrains decompiler
// Type: ProjectM.ITileSnappable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

#nullable disable
namespace ProjectM
{
  public class ITileSnappable : Il2CppObjectBase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Abstract_Virtual_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0;

    [CallerCount(0)]
    public virtual unsafe bool TryGetTileSnappingSettings(
      out TilePivotSettings pivotSettings,
      out TileSnapType snapType,
      out Nullable_Unboxed<HeightPlacementConfig> heightPlacementConfig)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref snapType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref heightPlacementConfig;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ITileSnappable.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Abstract_Virtual_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ITileSnappable()
    {
      Il2CppClassPointerStore<ITileSnappable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ITileSnappable));
      ITileSnappable.NativeMethodInfoPtr_TryGetTileSnappingSettings_Public_Abstract_Virtual_New_Boolean_byref_TilePivotSettings_byref_TileSnapType_byref_Nullable_Unboxed_1_HeightPlacementConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITileSnappable>.NativeClassPtr, 100667567);
    }

    public ITileSnappable(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
