// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeUsings
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public class CodeUsings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Inject;
    private static readonly System.IntPtr NativeFieldInfoPtr__InjectSegment;
    private static readonly System.IntPtr NativeFieldInfoPtr__BaseUsings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InjectedUsings;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldInjectedUsings;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodeDetect_CodeInject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterType_Public_Void_Type_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterStaticUsing_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterNamespace_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 635399, RefRangeEnd = 635401, XrefRangeStart = 635325, XrefRangeEnd = 635399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeUsings(CodeDetect baseUsings, CodeInject additionalUsings)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) baseUsings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) additionalUsings);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeUsings.NativeMethodInfoPtr__ctor_Public_Void_CodeDetect_CodeInject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635401, XrefRangeEnd = 635422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterType(Il2CppSystem.Type type, bool registerNestedTypesAsStaticAlias = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &registerNestedTypesAsStaticAlias;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeUsings.NativeMethodInfoPtr_RegisterType_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 635452, RefRangeEnd = 635453, XrefRangeStart = 635422, XrefRangeEnd = 635452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterStaticUsing(string alias, string fullTypeName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(alias);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fullTypeName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeUsings.NativeMethodInfoPtr_RegisterStaticUsing_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635453, XrefRangeEnd = 635465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterNamespace(string @namespace)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(@namespace);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeUsings.NativeMethodInfoPtr_RegisterNamespace_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635465, XrefRangeEnd = 635481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeUsings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeUsings()
    {
      Il2CppClassPointerStore<CodeUsings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeUsings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr);
      CodeUsings.NativeFieldInfoPtr__Inject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, nameof (_Inject));
      CodeUsings.NativeFieldInfoPtr__InjectSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, nameof (_InjectSegment));
      CodeUsings.NativeFieldInfoPtr__BaseUsings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, nameof (_BaseUsings));
      CodeUsings.NativeFieldInfoPtr__InjectedUsings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, nameof (_InjectedUsings));
      CodeUsings.NativeFieldInfoPtr_OldInjectedUsings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, nameof (OldInjectedUsings));
      CodeUsings.NativeMethodInfoPtr__ctor_Public_Void_CodeDetect_CodeInject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, 100663469);
      CodeUsings.NativeMethodInfoPtr_RegisterType_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, 100663470);
      CodeUsings.NativeMethodInfoPtr_RegisterStaticUsing_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, 100663471);
      CodeUsings.NativeMethodInfoPtr_RegisterNamespace_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, 100663472);
      CodeUsings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeUsings>.NativeClassPtr, 100663473);
    }

    public CodeUsings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CodeInject _Inject
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__Inject));
        return pointer == System.IntPtr.Zero ? (CodeInject) null : new CodeInject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__Inject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CodeSegment _InjectSegment
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__InjectSegment));
        return pointer == System.IntPtr.Zero ? (CodeSegment) null : new CodeSegment(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__InjectSegment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<string> _BaseUsings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__BaseUsings));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__BaseUsings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<string> _InjectedUsings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__InjectedUsings));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr__InjectedUsings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<string> OldInjectedUsings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr_OldInjectedUsings));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeUsings.NativeFieldInfoPtr_OldInjectedUsings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
