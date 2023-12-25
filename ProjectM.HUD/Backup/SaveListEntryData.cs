// Decompiled with JetBrains decompiler
// Type: SaveListEntryData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System.Runtime.InteropServices;

#nullable disable
public sealed class SaveListEntryData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_LastSaved;
  private static readonly System.IntPtr NativeFieldInfoPtr_SaveIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsCloudSaved;
  private static readonly System.IntPtr NativeFieldInfoPtr_Corrupt;

  static SaveListEntryData()
  {
    Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (SaveListEntryData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr);
    SaveListEntryData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, nameof (Name));
    SaveListEntryData.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, nameof (GameMode));
    SaveListEntryData.NativeFieldInfoPtr_LastSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, nameof (LastSaved));
    SaveListEntryData.NativeFieldInfoPtr_SaveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, nameof (SaveIndex));
    SaveListEntryData.NativeFieldInfoPtr_IsCloudSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, nameof (IsCloudSaved));
    SaveListEntryData.NativeFieldInfoPtr_Corrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, nameof (Corrupt));
  }

  public SaveListEntryData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public SaveListEntryData()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SaveListEntryData>.NativeClassPtr, data));
  }

  public unsafe string Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe GameModeType GameMode
  {
    get
    {
      return *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_GameMode));
    }
    [param: In] set
    {
      *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_GameMode)) = value;
    }
  }

  public unsafe Il2CppSystem.DateTime LastSaved
  {
    get
    {
      return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_LastSaved));
    }
    [param: In] set
    {
      *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_LastSaved)) = value;
    }
  }

  public unsafe int SaveIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_SaveIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_SaveIndex)) = value;
    }
  }

  public unsafe bool IsCloudSaved
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_IsCloudSaved));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_IsCloudSaved)) = value;
    }
  }

  public unsafe bool Corrupt
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_Corrupt));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveListEntryData.NativeFieldInfoPtr_Corrupt)) = value;
    }
  }
}
