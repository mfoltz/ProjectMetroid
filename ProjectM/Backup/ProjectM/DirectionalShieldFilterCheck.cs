// Decompiled with JetBrains decompiler
// Type: ProjectM.DirectionalShieldFilterCheck
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DirectionalShieldFilterCheck
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GetEntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTeam;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DirectionalShieldFilterCheck_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckFilter_Public_Boolean_HitConsumeFilter_Entity_Entity_SpellFilterEnum_0;
    [FieldOffset(0)]
    public ComponentDataFromEntity<EntityOwner> GetEntityOwner;
    [FieldOffset(32)]
    public ComponentDataFromEntity<Team> GetTeam;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1067382, RefRangeEnd = 1067384, XrefRangeStart = 1067376, XrefRangeEnd = 1067382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DirectionalShieldFilterCheck Create(ComponentSystemBase systemBase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DirectionalShieldFilterCheck.NativeMethodInfoPtr_Create_Public_Static_DirectionalShieldFilterCheck_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DirectionalShieldFilterCheck*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1067412, RefRangeEnd = 1067413, XrefRangeStart = 1067384, XrefRangeEnd = 1067412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckFilter(
      HitConsumeFilter filter,
      Entity self,
      Entity target,
      SpellFilterEnum spellType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &filter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spellType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DirectionalShieldFilterCheck.NativeMethodInfoPtr_CheckFilter_Public_Boolean_HitConsumeFilter_Entity_Entity_SpellFilterEnum_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DirectionalShieldFilterCheck()
    {
      Il2CppClassPointerStore<DirectionalShieldFilterCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DirectionalShieldFilterCheck));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalShieldFilterCheck>.NativeClassPtr);
      DirectionalShieldFilterCheck.NativeFieldInfoPtr_GetEntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalShieldFilterCheck>.NativeClassPtr, nameof (GetEntityOwner));
      DirectionalShieldFilterCheck.NativeFieldInfoPtr_GetTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalShieldFilterCheck>.NativeClassPtr, nameof (GetTeam));
      DirectionalShieldFilterCheck.NativeMethodInfoPtr_Create_Public_Static_DirectionalShieldFilterCheck_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalShieldFilterCheck>.NativeClassPtr, 100683962);
      DirectionalShieldFilterCheck.NativeMethodInfoPtr_CheckFilter_Public_Boolean_HitConsumeFilter_Entity_Entity_SpellFilterEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalShieldFilterCheck>.NativeClassPtr, 100683963);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalShieldFilterCheck>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
