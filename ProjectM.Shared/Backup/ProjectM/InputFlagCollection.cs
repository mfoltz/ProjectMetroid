// Decompiled with JetBrains decompiler
// Type: ProjectM.InputFlagCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputFlagCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayAbilities;

    static InputFlagCollection()
    {
      Il2CppClassPointerStore<InputFlagCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InputFlagCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFlagCollection>.NativeClassPtr);
      InputFlagCollection.NativeFieldInfoPtr_GameplayAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFlagCollection>.NativeClassPtr, nameof (GameplayAbilities));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputFlagCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe Il2CppStructArray<InputFlag> GameplayAbilities
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(InputFlagCollection.NativeFieldInfoPtr_GameplayAbilities, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<InputFlag>) null : new Il2CppStructArray<InputFlag>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InputFlagCollection.NativeFieldInfoPtr_GameplayAbilities, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
