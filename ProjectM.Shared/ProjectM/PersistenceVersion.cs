// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistenceVersion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PersistenceVersion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Version;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanLoad_Public_Boolean_PersistenceVersion_0;
    [FieldOffset(0)]
    public int Version;

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 411711, RefRangeEnd = 411739, XrefRangeStart = 411711, XrefRangeEnd = 411739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanLoad(PersistenceVersion otherVersion)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &otherVersion;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceVersion.NativeMethodInfoPtr_CanLoad_Public_Boolean_PersistenceVersion_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PersistenceVersion()
    {
      Il2CppClassPointerStore<PersistenceVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PersistenceVersion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceVersion>.NativeClassPtr);
      PersistenceVersion.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceVersion>.NativeClassPtr, nameof (Version));
      PersistenceVersion.NativeMethodInfoPtr_CanLoad_Public_Boolean_PersistenceVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceVersion>.NativeClassPtr, 100664938);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceVersion>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
