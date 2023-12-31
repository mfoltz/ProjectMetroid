// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.GameplayDebugRecord
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayDebugRecord
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_SystemId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionBegin;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionEnd;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionCheckBegin;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionCheckEnd;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionReportType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealDamageEventCommand;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventCommand;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventCommandEnd;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
    [FieldOffset(0)]
    public DebugRecordTypeEnum Type;
    [FieldOffset(4)]
    public SystemId SystemId;
    [FieldOffset(8)]
    public ConditionContainerBegin ConditionBegin;
    [FieldOffset(8)]
    public ConditionContainerEnd ConditionEnd;
    [FieldOffset(8)]
    public ConditionCheckBegin ConditionCheckBegin;
    [FieldOffset(8)]
    public ConditionCheckEnd ConditionCheckEnd;
    [FieldOffset(8)]
    public ConditionReportType ConditionReportType;
    [FieldOffset(8)]
    public DealDamageEventCommand DealDamageEventCommand;
    [FieldOffset(8)]
    public GameplayEventCommand GameplayEventCommand;
    [FieldOffset(8)]
    public GameplayEventCommandEnd GameplayEventCommandEnd;
    [FieldOffset(8)]
    public EntityEvent EntityEvent;

    static GameplayDebugRecord()
    {
      Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (GameplayDebugRecord));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr);
      GameplayDebugRecord.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (Type));
      GameplayDebugRecord.NativeFieldInfoPtr_SystemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (SystemId));
      GameplayDebugRecord.NativeFieldInfoPtr_ConditionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (ConditionBegin));
      GameplayDebugRecord.NativeFieldInfoPtr_ConditionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (ConditionEnd));
      GameplayDebugRecord.NativeFieldInfoPtr_ConditionCheckBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (ConditionCheckBegin));
      GameplayDebugRecord.NativeFieldInfoPtr_ConditionCheckEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (ConditionCheckEnd));
      GameplayDebugRecord.NativeFieldInfoPtr_ConditionReportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (ConditionReportType));
      GameplayDebugRecord.NativeFieldInfoPtr_DealDamageEventCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (DealDamageEventCommand));
      GameplayDebugRecord.NativeFieldInfoPtr_GameplayEventCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (GameplayEventCommand));
      GameplayDebugRecord.NativeFieldInfoPtr_GameplayEventCommandEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (GameplayEventCommandEnd));
      GameplayDebugRecord.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, nameof (EntityEvent));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayDebugRecord>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
