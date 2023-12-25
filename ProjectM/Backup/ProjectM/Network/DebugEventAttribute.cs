// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DebugEventAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class DebugEventAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UseSharedSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugEventAttribute()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugEventAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugEventAttribute()
    {
      Il2CppClassPointerStore<DebugEventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (DebugEventAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugEventAttribute>.NativeClassPtr);
      DebugEventAttribute.NativeFieldInfoPtr_UseSharedSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugEventAttribute>.NativeClassPtr, nameof (UseSharedSystem));
      DebugEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugEventAttribute>.NativeClassPtr, 100690763);
    }

    public DebugEventAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool UseSharedSystem
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventAttribute.NativeFieldInfoPtr_UseSharedSystem));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugEventAttribute.NativeFieldInfoPtr_UseSharedSystem)) = value;
      }
    }
  }
}
