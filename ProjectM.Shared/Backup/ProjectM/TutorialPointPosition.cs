// Decompiled with JetBrains decompiler
// Type: ProjectM.TutorialPointPosition
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using StunShared.UI;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TutorialPointPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Objective;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerRange;
    [FieldOffset(0)]
    public TutorialObjectiveType Objective;
    [FieldOffset(4)]
    public float TriggerRange;

    static TutorialPointPosition()
    {
      Il2CppClassPointerStore<TutorialPointPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TutorialPointPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPointPosition>.NativeClassPtr);
      TutorialPointPosition.NativeFieldInfoPtr_Objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPointPosition>.NativeClassPtr, nameof (Objective));
      TutorialPointPosition.NativeFieldInfoPtr_TriggerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPointPosition>.NativeClassPtr, nameof (TriggerRange));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialPointPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
