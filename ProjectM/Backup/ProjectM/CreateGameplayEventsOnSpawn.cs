// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnSpawn
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnSpawn
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public GameplayEventTarget Target;

    static CreateGameplayEventsOnSpawn()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnSpawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnSpawn>.NativeClassPtr);
      CreateGameplayEventsOnSpawn.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnSpawn>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnSpawn.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnSpawn>.NativeClassPtr, nameof (Target));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnSpawn>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
