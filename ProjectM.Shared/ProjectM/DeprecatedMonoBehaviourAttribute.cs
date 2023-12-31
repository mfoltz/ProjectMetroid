// Decompiled with JetBrains decompiler
// Type: ProjectM.DeprecatedMonoBehaviourAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class DeprecatedMonoBehaviourAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeprecatedMonoBehaviourAttribute(string description)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeprecatedMonoBehaviourAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(description);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeprecatedMonoBehaviourAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeprecatedMonoBehaviourAttribute()
    {
      Il2CppClassPointerStore<DeprecatedMonoBehaviourAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DeprecatedMonoBehaviourAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeprecatedMonoBehaviourAttribute>.NativeClassPtr);
      DeprecatedMonoBehaviourAttribute.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecatedMonoBehaviourAttribute>.NativeClassPtr, nameof (Description));
      DeprecatedMonoBehaviourAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedMonoBehaviourAttribute>.NativeClassPtr, 100667526);
    }

    public DeprecatedMonoBehaviourAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Description
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeprecatedMonoBehaviourAttribute.NativeFieldInfoPtr_Description)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeprecatedMonoBehaviourAttribute.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
