// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnTimePassed
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnTimePassed
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationFactorBasedOnLifetime;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public GameplayEventTarget Target;
    [FieldOffset(12)]
    public float Duration;
    [FieldOffset(16)]
    public float Time;
    [FieldOffset(20)]
    public float DurationFactorBasedOnLifetime;

    static CreateGameplayEventsOnTimePassed()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnTimePassed));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr);
      CreateGameplayEventsOnTimePassed.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnTimePassed.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr, nameof (Target));
      CreateGameplayEventsOnTimePassed.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr, nameof (Duration));
      CreateGameplayEventsOnTimePassed.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr, nameof (Time));
      CreateGameplayEventsOnTimePassed.NativeFieldInfoPtr_DurationFactorBasedOnLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr, nameof (DurationFactorBasedOnLifetime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnTimePassed>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
