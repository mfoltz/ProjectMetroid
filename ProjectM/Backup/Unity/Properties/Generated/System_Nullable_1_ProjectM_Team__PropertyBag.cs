// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.System_Nullable_1_ProjectM_Team__PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM;

#nullable disable
namespace Unity.Properties.Generated
{
  public class System_Nullable_1_ProjectM_Team__PropertyBag : 
    ContainerPropertyBag<Nullable_Unboxed<Team>>
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1170973, RefRangeEnd = 1170974, XrefRangeStart = 1170967, XrefRangeEnd = 1170973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe System_Nullable_1_ProjectM_Team__PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<System_Nullable_1_ProjectM_Team__PropertyBag>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(System_Nullable_1_ProjectM_Team__PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static System_Nullable_1_ProjectM_Team__PropertyBag()
    {
      Il2CppClassPointerStore<System_Nullable_1_ProjectM_Team__PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (System_Nullable_1_ProjectM_Team__PropertyBag));
      System_Nullable_1_ProjectM_Team__PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<System_Nullable_1_ProjectM_Team__PropertyBag>.NativeClassPtr, 100693189);
    }

    public System_Nullable_1_ProjectM_Team__PropertyBag(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
