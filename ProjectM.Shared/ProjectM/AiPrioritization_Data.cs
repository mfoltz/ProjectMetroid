// Decompiled with JetBrains decompiler
// Type: ProjectM.AiPrioritization_Data
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiPrioritization_Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UltraHighPriority;
    [FieldOffset(0)]
    public bool UltraHighPriority;

    static AiPrioritization_Data()
    {
      Il2CppClassPointerStore<AiPrioritization_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiPrioritization_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritization_Data>.NativeClassPtr);
      AiPrioritization_Data.NativeFieldInfoPtr_UltraHighPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritization_Data>.NativeClassPtr, nameof (UltraHighPriority));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritization_Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
