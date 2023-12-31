// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnRandomDeathPvPTimer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnRandomDeathPvPTimer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraTime_FirstStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraTime_AdditionalStacks;
    [FieldOffset(0)]
    public float ExtraTime_FirstStack;
    [FieldOffset(4)]
    public float ExtraTime_AdditionalStacks;

    static SpawnRandomDeathPvPTimer()
    {
      Il2CppClassPointerStore<SpawnRandomDeathPvPTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnRandomDeathPvPTimer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRandomDeathPvPTimer>.NativeClassPtr);
      SpawnRandomDeathPvPTimer.NativeFieldInfoPtr_ExtraTime_FirstStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRandomDeathPvPTimer>.NativeClassPtr, nameof (ExtraTime_FirstStack));
      SpawnRandomDeathPvPTimer.NativeFieldInfoPtr_ExtraTime_AdditionalStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRandomDeathPvPTimer>.NativeClassPtr, nameof (ExtraTime_AdditionalStacks));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRandomDeathPvPTimer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
