// Decompiled with JetBrains decompiler
// Type: ProjectM.Health
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
  public struct Health
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeOfDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRecoveryHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_HEALTH_THRESHOLD;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAtMaxHealth_Public_Static_Boolean_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAtMaxHealth_Public_Static_Boolean_byref_Health_0;
    [FieldOffset(0)]
    public ModifiableFloat MaxHealth;
    [FieldOffset(8)]
    public double TimeOfDeath;
    [FieldOffset(16)]
    public float Value;
    [FieldOffset(20)]
    public float MaxRecoveryHealth;
    [FieldOffset(24)]
    public bool IsDead;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727158, RefRangeEnd = 727159, XrefRangeStart = 727158, XrefRangeEnd = 727158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAtMaxHealth(float health, float maxHealth)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &health;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxHealth;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Health.NativeMethodInfoPtr_IsAtMaxHealth_Public_Static_Boolean_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 727159, RefRangeEnd = 727161, XrefRangeStart = 727159, XrefRangeEnd = 727159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAtMaxHealth([In] ref Health health)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref health;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Health.NativeMethodInfoPtr_IsAtMaxHealth_Public_Static_Boolean_byref_Health_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Health()
    {
      Il2CppClassPointerStore<Health>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Health));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Health>.NativeClassPtr);
      Health.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, nameof (MaxHealth));
      Health.NativeFieldInfoPtr_TimeOfDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, nameof (TimeOfDeath));
      Health.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, nameof (Value));
      Health.NativeFieldInfoPtr_MaxRecoveryHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, nameof (MaxRecoveryHealth));
      Health.NativeFieldInfoPtr_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, nameof (IsDead));
      Health.NativeFieldInfoPtr_MAX_HEALTH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Health>.NativeClassPtr, nameof (MAX_HEALTH_THRESHOLD));
      Health.NativeMethodInfoPtr_IsAtMaxHealth_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Health>.NativeClassPtr, 100664315);
      Health.NativeMethodInfoPtr_IsAtMaxHealth_Public_Static_Boolean_byref_Health_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Health>.NativeClassPtr, 100664316);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Health>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float MAX_HEALTH_THRESHOLD
    {
      get
      {
        float maxHealthThreshold;
        IL2CPP.il2cpp_field_static_get_value(Health.NativeFieldInfoPtr_MAX_HEALTH_THRESHOLD, (void*) &maxHealthThreshold);
        return maxHealthThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Health.NativeFieldInfoPtr_MAX_HEALTH_THRESHOLD, (void*) &value);
      }
    }
  }
}
