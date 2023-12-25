// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Convert_Item_OnConsume_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementCheckPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_FailedConvertSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandleConsumableStack;
    [FieldOffset(0)]
    public PrefabGUID PlacementCheckPrefab;
    [FieldOffset(4)]
    public PrefabGUID InputType;
    [FieldOffset(8)]
    public SequenceGUID ConvertSequence;
    [FieldOffset(12)]
    public SequenceGUID FailedConvertSequence;
    [FieldOffset(16)]
    public bool HandleConsumableStack;

    static Script_Convert_Item_OnConsume_DataServer()
    {
      Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Convert_Item_OnConsume_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr);
      Script_Convert_Item_OnConsume_DataServer.NativeFieldInfoPtr_PlacementCheckPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr, nameof (PlacementCheckPrefab));
      Script_Convert_Item_OnConsume_DataServer.NativeFieldInfoPtr_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr, nameof (InputType));
      Script_Convert_Item_OnConsume_DataServer.NativeFieldInfoPtr_ConvertSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr, nameof (ConvertSequence));
      Script_Convert_Item_OnConsume_DataServer.NativeFieldInfoPtr_FailedConvertSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr, nameof (FailedConvertSequence));
      Script_Convert_Item_OnConsume_DataServer.NativeFieldInfoPtr_HandleConsumableStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr, nameof (HandleConsumableStack));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
