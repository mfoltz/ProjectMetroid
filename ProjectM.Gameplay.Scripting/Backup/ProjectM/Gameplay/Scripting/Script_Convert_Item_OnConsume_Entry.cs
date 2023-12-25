// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_Entry
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Convert_Item_OnConsume_Entry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementType;
    [FieldOffset(0)]
    public PrefabGUID OutputType;
    [FieldOffset(8)]
    public PlacementTypeData PlacementType;

    static Script_Convert_Item_OnConsume_Entry()
    {
      Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Convert_Item_OnConsume_Entry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry>.NativeClassPtr);
      Script_Convert_Item_OnConsume_Entry.NativeFieldInfoPtr_OutputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry>.NativeClassPtr, nameof (OutputType));
      Script_Convert_Item_OnConsume_Entry.NativeFieldInfoPtr_PlacementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry>.NativeClassPtr, nameof (PlacementType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
