// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnAbilityImpaired
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnAbilityImpaired
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousIsImpaired;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    [FieldOffset(0)]
    public bool PreviousIsImpaired;
    [FieldOffset(4)]
    public GameplayEventId EventId;
    [FieldOffset(12)]
    public GameplayEventTarget Source;
    [FieldOffset(16)]
    public GameplayEventTarget Target;

    static CreateGameplayEventsOnAbilityImpaired()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnAbilityImpaired>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnAbilityImpaired));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityImpaired>.NativeClassPtr);
      CreateGameplayEventsOnAbilityImpaired.NativeFieldInfoPtr_PreviousIsImpaired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityImpaired>.NativeClassPtr, nameof (PreviousIsImpaired));
      CreateGameplayEventsOnAbilityImpaired.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityImpaired>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnAbilityImpaired.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityImpaired>.NativeClassPtr, nameof (Source));
      CreateGameplayEventsOnAbilityImpaired.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityImpaired>.NativeClassPtr, nameof (Target));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityImpaired>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
