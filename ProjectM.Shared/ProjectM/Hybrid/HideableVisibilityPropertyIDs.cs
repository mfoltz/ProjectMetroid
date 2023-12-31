// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HideableVisibilityPropertyIDs
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Hybrid
{
  public static class HideableVisibilityPropertyIDs : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HideableVisibility;

    static HideableVisibilityPropertyIDs()
    {
      Il2CppClassPointerStore<HideableVisibilityPropertyIDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (HideableVisibilityPropertyIDs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideableVisibilityPropertyIDs>.NativeClassPtr);
      HideableVisibilityPropertyIDs.NativeFieldInfoPtr_HideableVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideableVisibilityPropertyIDs>.NativeClassPtr, nameof (HideableVisibility));
    }

    public HideableVisibilityPropertyIDs(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int HideableVisibility
    {
      get
      {
        int hideableVisibility;
        IL2CPP.il2cpp_field_static_get_value(HideableVisibilityPropertyIDs.NativeFieldInfoPtr_HideableVisibility, (void*) &hideableVisibility);
        return hideableVisibility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HideableVisibilityPropertyIDs.NativeFieldInfoPtr_HideableVisibility, (void*) &value);
      }
    }
  }
}
