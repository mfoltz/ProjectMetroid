// Decompiled with JetBrains decompiler
// Type: ProjectM.CompatibleWithAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class CompatibleWithAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Types;
    private static readonly System.IntPtr NativeFieldInfoPtr_Group;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724662, XrefRangeEnd = 724667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CompatibleWithAttribute([Optional] Il2CppReferenceArray<Il2CppSystem.Type> types)
    {
      if (types == null)
        types = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CompatibleWithAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724667, XrefRangeEnd = 724670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CompatibleWithAttribute(string group, [Optional] Il2CppReferenceArray<Il2CppSystem.Type> types)
    {
      if (types == null)
        types = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(group);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CompatibleWithAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public CompatibleWithAttribute(params Il2CppSystem.Type[] types)
      : this(new Il2CppReferenceArray<Il2CppSystem.Type>(types))
    {
    }

    public CompatibleWithAttribute(string group, params Il2CppSystem.Type[] types)
      : this(group, new Il2CppReferenceArray<Il2CppSystem.Type>(types))
    {
    }

    static CompatibleWithAttribute()
    {
      Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CompatibleWithAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr);
      CompatibleWithAttribute.NativeFieldInfoPtr_Types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr, nameof (Types));
      CompatibleWithAttribute.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr, nameof (Group));
      CompatibleWithAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr, 100664089);
      CompatibleWithAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleWithAttribute>.NativeClassPtr, 100664090);
    }

    public CompatibleWithAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<Il2CppSystem.Type> Types
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CompatibleWithAttribute.NativeFieldInfoPtr_Types));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CompatibleWithAttribute.NativeFieldInfoPtr_Types), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string Group
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CompatibleWithAttribute.NativeFieldInfoPtr_Group)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CompatibleWithAttribute.NativeFieldInfoPtr_Group), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
