// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuff100
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff100
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Modifier;

    static BloodBuff100()
    {
      Il2CppClassPointerStore<BloodBuff100>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuff100));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff100>.NativeClassPtr);
      BloodBuff100.NativeFieldInfoPtr_Modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff100>.NativeClassPtr, nameof (Modifier));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff100>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float Modifier
    {
      get
      {
        float modifier;
        IL2CPP.il2cpp_field_static_get_value(BloodBuff100.NativeFieldInfoPtr_Modifier, (void*) &modifier);
        return modifier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BloodBuff100.NativeFieldInfoPtr_Modifier, (void*) &value);
      }
    }
  }
}
