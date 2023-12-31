// Decompiled with JetBrains decompiler
// Type: ProjectM.ScriptReferenceAttribute
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
  public class ScriptReferenceAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionDelegateType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScriptReferenceAttribute(Il2CppSystem.Type type)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptReferenceAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptReferenceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScriptReferenceAttribute()
    {
      Il2CppClassPointerStore<ScriptReferenceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ScriptReferenceAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptReferenceAttribute>.NativeClassPtr);
      ScriptReferenceAttribute.NativeFieldInfoPtr_FunctionDelegateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptReferenceAttribute>.NativeClassPtr, nameof (FunctionDelegateType));
      ScriptReferenceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReferenceAttribute>.NativeClassPtr, 100664277);
    }

    public ScriptReferenceAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Type FunctionDelegateType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptReferenceAttribute.NativeFieldInfoPtr_FunctionDelegateType));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptReferenceAttribute.NativeFieldInfoPtr_FunctionDelegateType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
