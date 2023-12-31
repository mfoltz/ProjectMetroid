// Decompiled with JetBrains decompiler
// Type: ProjectM.NeedComponentsAttribute
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
  public class NeedComponentsAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Components;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NeedComponentsAttribute([Optional] Il2CppReferenceArray<Il2CppSystem.Type> types)
    {
      if (types == null)
        types = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeedComponentsAttribute>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NeedComponentsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public NeedComponentsAttribute(params Il2CppSystem.Type[] types)
      : this(new Il2CppReferenceArray<Il2CppSystem.Type>(types))
    {
    }

    static NeedComponentsAttribute()
    {
      Il2CppClassPointerStore<NeedComponentsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (NeedComponentsAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeedComponentsAttribute>.NativeClassPtr);
      NeedComponentsAttribute.NativeFieldInfoPtr_Components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeedComponentsAttribute>.NativeClassPtr, nameof (Components));
      NeedComponentsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeedComponentsAttribute>.NativeClassPtr, 100664091);
    }

    public NeedComponentsAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<Il2CppSystem.Type> Components
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NeedComponentsAttribute.NativeFieldInfoPtr_Components));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NeedComponentsAttribute.NativeFieldInfoPtr_Components), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
