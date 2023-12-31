// Decompiled with JetBrains decompiler
// Type: ProjectM.DeathPvPTimer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DeathPvPTimer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraTime_FirstStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraTime_AdditionalStacks;
    [FieldOffset(0)]
    public float ExtraTime_FirstStack;
    [FieldOffset(4)]
    public float ExtraTime_AdditionalStacks;

    static DeathPvPTimer()
    {
      Il2CppClassPointerStore<DeathPvPTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DeathPvPTimer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathPvPTimer>.NativeClassPtr);
      DeathPvPTimer.NativeFieldInfoPtr_ExtraTime_FirstStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathPvPTimer>.NativeClassPtr, nameof (ExtraTime_FirstStack));
      DeathPvPTimer.NativeFieldInfoPtr_ExtraTime_AdditionalStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathPvPTimer>.NativeClassPtr, nameof (ExtraTime_AdditionalStacks));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeathPvPTimer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
