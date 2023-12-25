// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.GenerateFieldContextData
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public sealed class GenerateFieldContextData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetField;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_UniqueFieldPrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotFieldName;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentName;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeakRefFieldId;
    private static readonly System.IntPtr NativeFieldInfoPtr_BufferLengthField;

    static GenerateFieldContextData()
    {
      Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.Network", nameof (GenerateFieldContextData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr);
      GenerateFieldContextData.NativeFieldInfoPtr_TargetField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (TargetField));
      GenerateFieldContextData.NativeFieldInfoPtr_IsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (IsBuffer));
      GenerateFieldContextData.NativeFieldInfoPtr_UniqueFieldPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (UniqueFieldPrefix));
      GenerateFieldContextData.NativeFieldInfoPtr_SnapshotFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (SnapshotFieldName));
      GenerateFieldContextData.NativeFieldInfoPtr_SnapshotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (SnapshotName));
      GenerateFieldContextData.NativeFieldInfoPtr_ComponentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (ComponentName));
      GenerateFieldContextData.NativeFieldInfoPtr_WeakRefFieldId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (WeakRefFieldId));
      GenerateFieldContextData.NativeFieldInfoPtr_BufferLengthField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, nameof (BufferLengthField));
    }

    public GenerateFieldContextData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public GenerateFieldContextData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenerateFieldContextData>.NativeClassPtr, data));
    }

    public unsafe FieldInfo TargetField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_TargetField));
        return pointer == System.IntPtr.Zero ? (FieldInfo) null : new FieldInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_TargetField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsBuffer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_IsBuffer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_IsBuffer)) = value;
      }
    }

    public unsafe string UniqueFieldPrefix
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_UniqueFieldPrefix)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_UniqueFieldPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string SnapshotFieldName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_SnapshotFieldName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_SnapshotFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string SnapshotName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_SnapshotName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_SnapshotName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ComponentName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_ComponentName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_ComponentName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string WeakRefFieldId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_WeakRefFieldId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_WeakRefFieldId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string BufferLengthField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_BufferLengthField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateFieldContextData.NativeFieldInfoPtr_BufferLengthField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
