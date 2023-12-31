// Decompiled with JetBrains decompiler
// Type: ProjectM.AiPrioritization_State
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiPrioritization_State
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AccumulatedDeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccumulatedPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_Updated;
    [FieldOffset(0)]
    public float AccumulatedDeltaTime;
    [FieldOffset(4)]
    public int AccumulatedPriority;
    [FieldOffset(8)]
    public bool Updated;

    static AiPrioritization_State()
    {
      Il2CppClassPointerStore<AiPrioritization_State>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiPrioritization_State));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritization_State>.NativeClassPtr);
      AiPrioritization_State.NativeFieldInfoPtr_AccumulatedDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritization_State>.NativeClassPtr, nameof (AccumulatedDeltaTime));
      AiPrioritization_State.NativeFieldInfoPtr_AccumulatedPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritization_State>.NativeClassPtr, nameof (AccumulatedPriority));
      AiPrioritization_State.NativeFieldInfoPtr_Updated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritization_State>.NativeClassPtr, nameof (Updated));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritization_State>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
