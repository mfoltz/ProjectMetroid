// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnTick
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnTick
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_CallScriptOnTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomTickOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomTickInterval;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public GameplayEventTarget Target;
    [FieldOffset(12)]
    public float TickInterval;
    [FieldOffset(16)]
    public float TickTime;
    [FieldOffset(20)]
    public int MaxTicks;
    [FieldOffset(24)]
    public bool CallScriptOnTick;
    [FieldOffset(28)]
    public float RandomTickOffset;
    [FieldOffset(32)]
    public float RandomTickInterval;

    static CreateGameplayEventsOnTick()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnTick));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr);
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (Target));
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_TickInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (TickInterval));
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_TickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (TickTime));
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_MaxTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (MaxTicks));
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_CallScriptOnTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (CallScriptOnTick));
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_RandomTickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (RandomTickOffset));
      CreateGameplayEventsOnTick.NativeFieldInfoPtr_RandomTickInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, nameof (RandomTickInterval));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnTick>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
