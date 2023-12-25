// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_RemoteImprison_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_RemoteImprison_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ImprisonEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveCharmBuffType;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoEmptyPrisonInBase_LKey;
    [FieldOffset(0)]
    public PrefabGUID ImprisonEvent;
    [FieldOffset(4)]
    public PrefabGUID ConsumeItemType;
    [FieldOffset(8)]
    public PrefabGUID RemoveCharmBuffType;
    [FieldOffset(12)]
    public AssetGuid NoEmptyPrisonInBase_LKey;

    static Script_RemoteImprison_DataServer()
    {
      Il2CppClassPointerStore<Script_RemoteImprison_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_RemoteImprison_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_RemoteImprison_DataServer>.NativeClassPtr);
      Script_RemoteImprison_DataServer.NativeFieldInfoPtr_ImprisonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_RemoteImprison_DataServer>.NativeClassPtr, nameof (ImprisonEvent));
      Script_RemoteImprison_DataServer.NativeFieldInfoPtr_ConsumeItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_RemoteImprison_DataServer>.NativeClassPtr, nameof (ConsumeItemType));
      Script_RemoteImprison_DataServer.NativeFieldInfoPtr_RemoveCharmBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_RemoteImprison_DataServer>.NativeClassPtr, nameof (RemoveCharmBuffType));
      Script_RemoteImprison_DataServer.NativeFieldInfoPtr_NoEmptyPrisonInBase_LKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_RemoteImprison_DataServer>.NativeClassPtr, nameof (NoEmptyPrisonInBase_LKey));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_RemoteImprison_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
