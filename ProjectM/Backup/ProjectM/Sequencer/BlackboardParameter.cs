// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.BlackboardParameter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class BlackboardParameter : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Edit;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_BlackboardParameterCategory_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_BlackboardParameterCategory_SocketDefaultValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlackboardParameter_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlackboardParameter()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlackboardParameter.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094267, XrefRangeEnd = 1094275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlackboardParameter(string name, BlackboardRegisterType type, bool edit = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &edit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094275, XrefRangeEnd = 1094283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlackboardParameter(
      string name,
      BlackboardRegisterType type,
      BlackboardParameterCategory category,
      bool edit = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &edit;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_BlackboardParameterCategory_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094283, XrefRangeEnd = 1094291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlackboardParameter(
      string name,
      BlackboardRegisterType type,
      BlackboardParameterCategory category,
      SocketDefaultValue defaultValue)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_BlackboardParameterCategory_SocketDefaultValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094291, XrefRangeEnd = 1094299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlackboardParameter(BlackboardParameter parameter)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameter);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_BlackboardParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlackboardParameter()
    {
      Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (BlackboardParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr);
      BlackboardParameter.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, nameof (Name));
      BlackboardParameter.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, nameof (Type));
      BlackboardParameter.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, nameof (Category));
      BlackboardParameter.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, nameof (Guid));
      BlackboardParameter.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, nameof (DefaultValue));
      BlackboardParameter.NativeFieldInfoPtr_Edit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, nameof (Edit));
      BlackboardParameter.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, 100686747);
      BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, 100686748);
      BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_BlackboardParameterCategory_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, 100686749);
      BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_String_BlackboardRegisterType_BlackboardParameterCategory_SocketDefaultValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, 100686750);
      BlackboardParameter.NativeMethodInfoPtr__ctor_Public_Void_BlackboardParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameter>.NativeClassPtr, 100686751);
    }

    public BlackboardParameter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe BlackboardRegisterType Type
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe BlackboardParameterCategory Category
    {
      get
      {
        return *(BlackboardParameterCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Category));
      }
      [param: In] set
      {
        *(BlackboardParameterCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Category)) = value;
      }
    }

    public unsafe string Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe SocketDefaultValue DefaultValue
    {
      get
      {
        return *(SocketDefaultValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_DefaultValue));
      }
      [param: In] set
      {
        *(SocketDefaultValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_DefaultValue)) = value;
      }
    }

    public unsafe bool Edit
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Edit));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameter.NativeFieldInfoPtr_Edit)) = value;
      }
    }
  }
}
