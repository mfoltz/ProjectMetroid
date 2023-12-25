// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Convert_Item_OnConsume_Entry_Editor
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [Serializable]
  public sealed class Script_Convert_Item_OnConsume_Entry_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementType;

    static Script_Convert_Item_OnConsume_Entry_Editor()
    {
      Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Convert_Item_OnConsume_Entry_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry_Editor>.NativeClassPtr);
      Script_Convert_Item_OnConsume_Entry_Editor.NativeFieldInfoPtr_OutputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry_Editor>.NativeClassPtr, nameof (OutputType));
      Script_Convert_Item_OnConsume_Entry_Editor.NativeFieldInfoPtr_PlacementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry_Editor>.NativeClassPtr, nameof (PlacementType));
    }

    public Script_Convert_Item_OnConsume_Entry_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Script_Convert_Item_OnConsume_Entry_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Convert_Item_OnConsume_Entry_Editor>.NativeClassPtr, data));
    }

    public unsafe PrefabGuidComponent OutputType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume_Entry_Editor.NativeFieldInfoPtr_OutputType));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume_Entry_Editor.NativeFieldInfoPtr_OutputType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlacementTypeDataAsLongs PlacementType
    {
      get
      {
        return *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume_Entry_Editor.NativeFieldInfoPtr_PlacementType));
      }
      [param: In] set
      {
        *(PlacementTypeDataAsLongs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Convert_Item_OnConsume_Entry_Editor.NativeFieldInfoPtr_PlacementType)) = value;
      }
    }
  }
}
