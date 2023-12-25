// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourCodeGeneration
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class BehaviourCodeGeneration : Il2CppSystem.Object
  {
    static BehaviourCodeGeneration()
    {
      Il2CppClassPointerStore<BehaviourCodeGeneration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.Behaviours", nameof (BehaviourCodeGeneration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourCodeGeneration>.NativeClassPtr);
    }

    public BehaviourCodeGeneration(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public class ExpandAttribute : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ExpandAttribute()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourCodeGeneration.ExpandAttribute>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourCodeGeneration.ExpandAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ExpandAttribute()
      {
        Il2CppClassPointerStore<BehaviourCodeGeneration.ExpandAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourCodeGeneration>.NativeClassPtr, nameof (ExpandAttribute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourCodeGeneration.ExpandAttribute>.NativeClassPtr);
        BehaviourCodeGeneration.ExpandAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourCodeGeneration.ExpandAttribute>.NativeClassPtr, 100663320);
      }

      public ExpandAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class DontGenerateAuthoringClass : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DontGenerateAuthoringClass()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourCodeGeneration.DontGenerateAuthoringClass>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourCodeGeneration.DontGenerateAuthoringClass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DontGenerateAuthoringClass()
      {
        Il2CppClassPointerStore<BehaviourCodeGeneration.DontGenerateAuthoringClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourCodeGeneration>.NativeClassPtr, nameof (DontGenerateAuthoringClass));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourCodeGeneration.DontGenerateAuthoringClass>.NativeClassPtr);
        BehaviourCodeGeneration.DontGenerateAuthoringClass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourCodeGeneration.DontGenerateAuthoringClass>.NativeClassPtr, 100663321);
      }

      public DontGenerateAuthoringClass(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ReadsFrom : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Types;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

      [CallerCount(23)]
      [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ReadsFrom([Optional] Il2CppReferenceArray<Il2CppSystem.Type> types)
      {
        if (types == null)
          types = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
        // ISSUE: explicit constructor call
        this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourCodeGeneration.ReadsFrom>.NativeClassPtr));
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourCodeGeneration.ReadsFrom.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public ReadsFrom(params Il2CppSystem.Type[] types)
        : this(new Il2CppReferenceArray<Il2CppSystem.Type>(types))
      {
      }

      static ReadsFrom()
      {
        Il2CppClassPointerStore<BehaviourCodeGeneration.ReadsFrom>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourCodeGeneration>.NativeClassPtr, nameof (ReadsFrom));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourCodeGeneration.ReadsFrom>.NativeClassPtr);
        BehaviourCodeGeneration.ReadsFrom.NativeFieldInfoPtr_Types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourCodeGeneration.ReadsFrom>.NativeClassPtr, nameof (Types));
        BehaviourCodeGeneration.ReadsFrom.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourCodeGeneration.ReadsFrom>.NativeClassPtr, 100663322);
      }

      public ReadsFrom(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppReferenceArray<Il2CppSystem.Type> Types
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourCodeGeneration.ReadsFrom.NativeFieldInfoPtr_Types));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourCodeGeneration.ReadsFrom.NativeFieldInfoPtr_Types), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class WritesTo : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Types;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

      [CallerCount(23)]
      [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe WritesTo([Optional] Il2CppReferenceArray<Il2CppSystem.Type> types)
      {
        if (types == null)
          types = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
        // ISSUE: explicit constructor call
        this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourCodeGeneration.WritesTo>.NativeClassPtr));
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourCodeGeneration.WritesTo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public WritesTo(params Il2CppSystem.Type[] types)
        : this(new Il2CppReferenceArray<Il2CppSystem.Type>(types))
      {
      }

      static WritesTo()
      {
        Il2CppClassPointerStore<BehaviourCodeGeneration.WritesTo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourCodeGeneration>.NativeClassPtr, nameof (WritesTo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourCodeGeneration.WritesTo>.NativeClassPtr);
        BehaviourCodeGeneration.WritesTo.NativeFieldInfoPtr_Types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourCodeGeneration.WritesTo>.NativeClassPtr, nameof (Types));
        BehaviourCodeGeneration.WritesTo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourCodeGeneration.WritesTo>.NativeClassPtr, 100663323);
      }

      public WritesTo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppReferenceArray<Il2CppSystem.Type> Types
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourCodeGeneration.WritesTo.NativeFieldInfoPtr_Types));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourCodeGeneration.WritesTo.NativeFieldInfoPtr_Types), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
