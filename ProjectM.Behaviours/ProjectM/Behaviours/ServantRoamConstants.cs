// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.ServantRoamConstants
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public class ServantRoamConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_EXPANSIONS_SAME_FLOOR;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_EXPANSIONS_FLOOR_CHANGE;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantRoamConstants()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantRoamConstants>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantRoamConstants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantRoamConstants()
    {
      Il2CppClassPointerStore<ServantRoamConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (ServantRoamConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantRoamConstants>.NativeClassPtr);
      ServantRoamConstants.NativeFieldInfoPtr_MAX_EXPANSIONS_SAME_FLOOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantRoamConstants>.NativeClassPtr, nameof (MAX_EXPANSIONS_SAME_FLOOR));
      ServantRoamConstants.NativeFieldInfoPtr_MAX_EXPANSIONS_FLOOR_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantRoamConstants>.NativeClassPtr, nameof (MAX_EXPANSIONS_FLOOR_CHANGE));
      ServantRoamConstants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantRoamConstants>.NativeClassPtr, 100665569);
    }

    public ServantRoamConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MAX_EXPANSIONS_SAME_FLOOR
    {
      get
      {
        int expansionsSameFloor;
        IL2CPP.il2cpp_field_static_get_value(ServantRoamConstants.NativeFieldInfoPtr_MAX_EXPANSIONS_SAME_FLOOR, (void*) &expansionsSameFloor);
        return expansionsSameFloor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServantRoamConstants.NativeFieldInfoPtr_MAX_EXPANSIONS_SAME_FLOOR, (void*) &value);
      }
    }

    public static unsafe int MAX_EXPANSIONS_FLOOR_CHANGE
    {
      get
      {
        int expansionsFloorChange;
        IL2CPP.il2cpp_field_static_get_value(ServantRoamConstants.NativeFieldInfoPtr_MAX_EXPANSIONS_FLOOR_CHANGE, (void*) &expansionsFloorChange);
        return expansionsFloorChange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServantRoamConstants.NativeFieldInfoPtr_MAX_EXPANSIONS_FLOOR_CHANGE, (void*) &value);
      }
    }
  }
}
