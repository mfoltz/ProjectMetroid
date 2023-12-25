// Decompiled with JetBrains decompiler
// Type: WindParticleJob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Wind;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

#nullable disable
public class WindParticleJob : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_WindIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_DynamicWindMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr__ParticleSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr__Job;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateVelocity_Private_Static_float3_byref_UpdateParticlesJob_float3_float3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnParticleUpdateJobScheduled_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921778, RefRangeEnd = 921779, XrefRangeStart = 921777, XrefRangeEnd = 921778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 CalculateVelocity(
    ref WindParticleJob.UpdateParticlesJob job,
    float3 force,
    float3 oldVel,
    float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref job;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &force;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &oldVel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindParticleJob.NativeMethodInfoPtr_CalculateVelocity_Private_Static_float3_byref_UpdateParticlesJob_float3_float3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921779, XrefRangeEnd = 921783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WindParticleJob.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921783, XrefRangeEnd = 921804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WindParticleJob.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921804, XrefRangeEnd = 921816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnParticleUpdateJobScheduled()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WindParticleJob.NativeMethodInfoPtr_OnParticleUpdateJobScheduled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921816, XrefRangeEnd = 921817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WindParticleJob()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WindParticleJob.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WindParticleJob()
  {
    Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (WindParticleJob));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr);
    WindParticleJob.NativeFieldInfoPtr_WindIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, nameof (WindIntensity));
    WindParticleJob.NativeFieldInfoPtr_DynamicWindMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, nameof (DynamicWindMultiplier));
    WindParticleJob.NativeFieldInfoPtr__ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, nameof (_ParticleSystem));
    WindParticleJob.NativeFieldInfoPtr__Job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, nameof (_Job));
    WindParticleJob.NativeMethodInfoPtr_CalculateVelocity_Private_Static_float3_byref_UpdateParticlesJob_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, 100663724);
    WindParticleJob.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, 100663725);
    WindParticleJob.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, 100663726);
    WindParticleJob.NativeMethodInfoPtr_OnParticleUpdateJobScheduled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, 100663727);
    WindParticleJob.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, 100663728);
  }

  public WindParticleJob(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float WindIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr_WindIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr_WindIntensity)) = value;
    }
  }

  public unsafe float DynamicWindMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr_DynamicWindMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr_DynamicWindMultiplier)) = value;
    }
  }

  public unsafe ParticleSystem _ParticleSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr__ParticleSystem));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr__ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WindParticleJob.UpdateParticlesJob _Job
  {
    get
    {
      return *(WindParticleJob.UpdateParticlesJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr__Job));
    }
    [param: In] set
    {
      *(WindParticleJob.UpdateParticlesJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindParticleJob.NativeFieldInfoPtr__Job)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateParticlesJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WindStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicWindStrengthMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_WindInput;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ParticleSystemJobData_Int32_0;
    [FieldOffset(0)]
    public float WindStrength;
    [FieldOffset(4)]
    public float DynamicWindStrengthMultiplier;
    [FieldOffset(8)]
    public float DeltaTime;
    [FieldOffset(12)]
    public float4x4 TransformMatrix;
    [FieldOffset(80)]
    public WindInput WindInput;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 921776, RefRangeEnd = 921777, XrefRangeStart = 921772, XrefRangeEnd = 921776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ParticleSystemJobData particles, int i)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &particles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &i;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindParticleJob.UpdateParticlesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ParticleSystemJobData_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateParticlesJob()
    {
      Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindParticleJob>.NativeClassPtr, nameof (UpdateParticlesJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr);
      WindParticleJob.UpdateParticlesJob.NativeFieldInfoPtr_WindStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr, nameof (WindStrength));
      WindParticleJob.UpdateParticlesJob.NativeFieldInfoPtr_DynamicWindStrengthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr, nameof (DynamicWindStrengthMultiplier));
      WindParticleJob.UpdateParticlesJob.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr, nameof (DeltaTime));
      WindParticleJob.UpdateParticlesJob.NativeFieldInfoPtr_TransformMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr, nameof (TransformMatrix));
      WindParticleJob.UpdateParticlesJob.NativeFieldInfoPtr_WindInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr, nameof (WindInput));
      WindParticleJob.UpdateParticlesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ParticleSystemJobData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr, 100663729);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindParticleJob.UpdateParticlesJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
